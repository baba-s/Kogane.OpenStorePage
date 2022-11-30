using System;
using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// ストアページを開く構造体
    /// 参考サイト様：https://qiita.com/ptkyoku/items/4a8e9bd907a20af95191
    /// </summary>
    [Serializable]
    public struct OpenStorePage
    {
        //================================================================================
        // 変数(SerializeField)
        //================================================================================
        [SerializeField] private string m_iosUrl;
        [SerializeField] private string m_androidUrl;

        //================================================================================
        // プロパティ
        //================================================================================
        public string IOSUrl     => m_iosUrl;
        public string AndroidUrl => m_androidUrl;

        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public OpenStorePage
        (
            string iosId,
            string androidId
        )
        {
            m_iosUrl     = $"itms-apps://itunes.apple.com/app/id{iosId}?mt=8";
            m_androidUrl = $"market://details?id={androidId}";
        }

        /// <summary>
        /// ストアページを開きます
        /// </summary>
        public readonly void OpenURL()
        {
            switch ( Application.platform )
            {
                case RuntimePlatform.IPhonePlayer:
                    OpeniOS();
                    return;
                case RuntimePlatform.Android:
                    OpenAndroid();
                    return;
            }
        }

        /// <summary>
        /// iOS でストアページを開きます
        /// </summary>
        public readonly void OpeniOS()
        {
            Application.OpenURL( m_iosUrl );
        }

        /// <summary>
        /// Android でストアページを開きます
        /// </summary>
        public readonly void OpenAndroid()
        {
            Application.OpenURL( m_androidUrl );
        }

        /// <summary>
        /// JSON 形式の文字列に変換して返します
        /// </summary>
        public override string ToString()
        {
            return JsonUtility.ToJson( this, true );
        }
    }
}