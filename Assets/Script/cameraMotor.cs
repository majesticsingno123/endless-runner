using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMotor : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform lookAt;
    private Vector3 startOffset;
   
    //private float transition = 0.0f;


    void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").transform;
        startOffset = transform.position - lookAt.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {

            Vector3 targetPos = lookAt.position + startOffset;
            transform.position = targetPos;
      

       
        //transform.position = lookAt.position + startOffset;


    }
}
