using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    private float _oldMousePositionX;
    private float eulerY;

    private void Update()
    {
        MouseRotate();
    }

    private void MouseRotate()
    {
        var deltaX = Input.mousePosition.x - _oldMousePositionX;
        
        _oldMousePositionX = Input.mousePosition.x;
        
        eulerY += deltaX;

        eulerY = Mathf.Clamp(eulerY, -50, 50);

        transform.eulerAngles = new Vector3(0, eulerY,0);

    }
}
