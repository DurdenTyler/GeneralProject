using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int _coins;

    public void AddCoins(int value)
    {
        _coins += value;
    }
}
