using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private string _direction;
    private float _walkSpeed = 1.5f;
    private float _runSpeed = 2.5f;

    void Update()
    {
        WhatIsKeyTapped();
        Move();
    }

    private void Move()
    {
        Vector3 newPosition = transform.position;
        
        switch (_direction)
        {
            case "forward":
                newPosition += transform.forward * (Time.deltaTime * _walkSpeed);
                _animator.SetBool("GoForward", true);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
                
            case "back":
                newPosition -= transform.forward * (Time.deltaTime * _walkSpeed);
                _animator.SetBool("GoBack", true);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
            
            case "left":
                newPosition -= transform.right* (Time.deltaTime * _walkSpeed);
                _animator.SetBool("GoLeft", true);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
                
            case "right":
                newPosition += transform.right * (Time.deltaTime * _walkSpeed);
                _animator.SetBool("GoRight", true);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
            
            case "runForward":
                newPosition += transform.forward * (Time.deltaTime * _runSpeed);
                _animator.SetBool("RunForward", true);
                _animator.SetBool("GoForward", false);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
                
            case "runBack":
                newPosition -= transform.forward * (Time.deltaTime * _runSpeed);
                _animator.SetBool("RunBack", true);
                _animator.SetBool("GoBack", false);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
            
            case "runLeft":
                newPosition -= transform.right* (Time.deltaTime * _runSpeed);
                _animator.SetBool("RunLeft", true);
                _animator.SetBool("GoLeft", false);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
                
            case "runRight":
                newPosition += transform.right * (Time.deltaTime * _runSpeed);
                _animator.SetBool("RunRight", true);
                _animator.SetBool("GoRight", false);
                // Ограничения на выход с пути newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
                transform.position = newPosition;
                break;
            
            case "stay":
                StateStay();
                transform.position = transform.position;
                break;
        }
    }
    
    // This method in Move()
    private void StateStay()
    {
        _animator.SetBool("GoForward", false);
        _animator.SetBool("RunForward", false);
        _animator.SetBool("GoBack", false);
        _animator.SetBool("RunBack", false);
        _animator.SetBool("GoLeft", false);
        _animator.SetBool("RunLeft", false);
        _animator.SetBool("GoRight", false);
        _animator.SetBool("RunRight", false);
    }

    private void WhatIsKeyTapped()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _direction = "forward";
        } else if (Input.GetKey(KeyCode.Alpha1))
        {
            _direction = "runForward";
        } else if (Input.GetKey(KeyCode.S))
        {
            _direction = "back";
        } else if (Input.GetKey(KeyCode.Alpha2))
        {
            _direction = "runBack";
        } else if (Input.GetKey(KeyCode.A))
        {
            _direction = "left";
        } else if (Input.GetKey(KeyCode.Alpha3))
        {
            _direction = "runLeft";
        } else if (Input.GetKey(KeyCode.D))
        {
            _direction = "right";
        }else if (Input.GetKey(KeyCode.Alpha4))
        {
            _direction = "runRight";
        } else
        {
            _direction = "stay";
        }
    }
}

