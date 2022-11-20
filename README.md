# Kogane Open Store Page

iOS / Android でストアページを開く構造体

## 使用例

```cs
using Kogane;
using UnityEngine;

public sealed class Example : MonoBehaviour
{
    // Pokémon GO のストアページを開く
    private readonly OpenStorePage m_openStorePage = new
    (
        iosId: "1094591345",
        androidId: "com.nianticlabs.pokemongo"
    );

    private void Start()
    {
        m_openStorePage.OpenURL();
    }
}
```