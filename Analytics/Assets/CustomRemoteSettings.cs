using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomRemoteSettings : MonoBehaviour
{
    private string _colorHex = "";
    public string ColorHex
    {
        get { return _colorHex; }
        set {
            Color parsedColor;
            if (ColorUtility.TryParseHtmlString(value, out parsedColor))
            {
                _colorHex = value;
                Renderer renderer = GetComponent<>();
                renderer.material.SetColor("_Color", parsedColor);
            }
        }
    }
}
