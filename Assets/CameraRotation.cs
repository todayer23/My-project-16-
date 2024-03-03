﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float RotationSpeed;
    public Transform CameraAxisTransform;
    public float maxAngle;
    public float minAngle;
    

    // Update is called once per frame
    void Update()
    {
        var newAngleX = CameraAxisTransform.localEulerAngles.x + Time.deltaTime * -RotationSpeed * Input.GetAxis("Mouse Y");
        if(newAngleX > 180)
            {
                newAngleX -= 360;
            }
        newAngleX = Mathf.Clamp(newAngleX, minAngle, maxAngle);
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X"), 0);
        CameraAxisTransform.localEulerAngles = new Vector3(newAngleX, 0, 0);
    }
}
