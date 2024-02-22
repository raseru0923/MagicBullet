using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ButtonText : MonoBehaviour
{
    private TextParameter ButtonTextParameter;

    public void SetParameter()
    {
        ButtonTextParameter = UnityEditor.AssetDatabase.LoadAssetAtPath<TextParameter>("Assets/Scripts/ScriptableObject/ButtonTextParameter.asset");
        Text text = this.GetComponent<Text>();
        text.font = (ButtonTextParameter.TextFont != null) ? ButtonTextParameter.TextFont : text.font;
        text.fontStyle = ButtonTextParameter.TextFontStyle;
        text.fontSize = ButtonTextParameter.TextFontSize;
        text.color = ButtonTextParameter.TextColor;
    }
}
