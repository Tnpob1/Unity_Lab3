using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    // This script allows the user to rotate the turret,
    // and raise and lower the barrel elevation.
    public Transform Barrel1;
    public float min = -30;
    public float max = 30;

    float elevation = 0;

    void Update()
    {
        // horizontal rotation control
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        // barrel elevation control
        float v = Input.GetAxis("Vertical");
        elevation = Mathf.Clamp(elevation+v,min,max);
        Barrel1.localRotation = Quaternion.Euler(elevation,0,0);
    }
}