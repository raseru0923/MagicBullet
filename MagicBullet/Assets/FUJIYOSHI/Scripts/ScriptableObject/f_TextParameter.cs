using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TextParameter", menuName = "ScriptableObjects/TextParameter")]
public class f_TextParameter : ScriptableObject
{
    public Font TextFont;
    public FontStyle TextFontStyle = FontStyle.Normal;
    public int TextFontSize = 14;
    public Color TextColor = Color.white;
}
