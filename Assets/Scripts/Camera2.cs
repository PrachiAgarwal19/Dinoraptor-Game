using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2 : MonoBehaviour
{
    public Transform target;

   private Vector3 offset;

   public bool useOffsetValues;

   public float rotateSpeed;

   public Transform pivot;

    public float maxViewAngle;
    public float minViewAngle;

    public bool invertY;


    //Use this for initialization
    void Start()
    {
        offset = transform.position - target.position;
    }//update is called once per frame
   
    void Update()
    {
        transform.position=target.position+offset;
        Vector3 movementDirection = new Vector3(Input.GetAxis("Horizontal"),0, Input.GetAxis("Vertical"));

        if(movementDirection!=Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movementDirection);
        }
        else
        {
            Vector3 lookForward;
            lookForward.x=0;
            lookForward.y=0;
            lookForward.z=1f;
            transform.rotation = Quaternion.LookRotation(lookForward);
        }
    }
}
