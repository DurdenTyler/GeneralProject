using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform _shootPoint;
    //[SerializeField] private float _power = 5;
    //[SerializeField] private float _damage = 20;
    [SerializeField] private GameObject _particleSystem;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 direction = _shootPoint.forward;
            var spread = new Vector3(direction.x + Random.Range(-0.04f, 0.03f), (direction.y) + Random.Range(-0.01f, 0.04f), direction.z);
            
            if (Physics.Raycast(_shootPoint.position, spread, out var hit))
            {
                var rigidbody = hit.transform.gameObject.GetComponent<Rigidbody>();

                Instantiate(_particleSystem, hit.point, Quaternion.LookRotation(hit.normal, Vector3.up));

                if (rigidbody == null)
                {
                    return;
                }
                else
                {
                    rigidbody.AddForce(transform.forward * 4f, ForceMode.Impulse);
                }
            }
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(_shootPoint.position, _shootPoint.forward * 9999);
    }
}
