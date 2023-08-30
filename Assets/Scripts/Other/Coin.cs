using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void Update()
    {
        transform.Rotate(0,360f * (Time.deltaTime * 0.6f), 0);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        _gameManager.AddCoins(1);
        Destroy(gameObject);
    }
    
    
    
}
