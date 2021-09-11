using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour { 

   public Transform target;

   public Vector3 offset;

   public bool useOffsetValue;

   public float rotateSpeed;

    void Start()
    {
        if (!useOffsetValues)
        {
            offset = target.position;
        }
    }
   
   void Update()
    {
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.rotate(0, horizontal, 0);
        float vertical  = Input.GetAxis("Mouse Y") * rotateSpeed;
        target.rotate(Vvertical,0,0);
        float desiredXAngle = target.eulerAngles.x;
        float desiredYAngle = target.eulerAngles.y;
        Quaternian rotation = Quaternian.Euler(desiredXAngle, desiredYAngle, 0);

        
       
        transform.position = target.position - (rotation*offset);
        // tranform.position = target.position - offset;
        transform.LookAt(target);
    }

}