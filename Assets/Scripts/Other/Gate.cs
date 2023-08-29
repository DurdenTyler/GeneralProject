using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;





public class Gate : MonoBehaviour
{
    [SerializeField] private int _countOfCoinsValue;

    [SerializeField] private GateAppereance _gateAppereance;


    private void Update()
    {
        _gateAppereance.OnValidateVisual(_countOfCoinsValue);
    }
}
