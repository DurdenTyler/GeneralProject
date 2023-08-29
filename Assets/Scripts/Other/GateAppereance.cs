using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GateAppereance : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    
    [SerializeField] private Color _positiveColor;
    [SerializeField] private Color _negativeColor;

    [SerializeField] private Image _backgroundTop;
    [SerializeField] private Image _backgroundBottom;


    public void OnValidateVisual(int value)
    {
        string prefix = "";
        
        if (value > 0)
        {
            prefix = "+";
            SetColor(_positiveColor);
        } else if (value == 0)
        {
            SetColor(Color.gray);
        }
        else
        {
            SetColor(_negativeColor);
        }
        
        _text.text = prefix + value.ToString();
    }
    
    private void SetColor(Color color)
    {
        _backgroundTop.color = color;
        _backgroundBottom.color = new Color(color.r, color.g, color.b, 0.5f);
    }
}
