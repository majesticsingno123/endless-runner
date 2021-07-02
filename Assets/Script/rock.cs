using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class rock : MonoBehaviour
{
    
   void Update()
    {
        var speed = -30f;
        var gravity = -12f;
        GetComponent<Rigidbody>().velocity = new Vector3(0f, gravity, speed);
    }
}
