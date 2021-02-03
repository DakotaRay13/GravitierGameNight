 //The following script is used for the rotation of Gravity
 //and the main character using the Accelerometer.
 //  -Dakota Ray Manley
    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingGravity : MonoBehaviour
{
    public float GravityMagnitude = 10f;

    private void FixedUpdate()
    {        
        //Rotates the gravity with the accelerometer
        Physics2D.gravity = Input.acceleration * GravityMagnitude;
    }
}