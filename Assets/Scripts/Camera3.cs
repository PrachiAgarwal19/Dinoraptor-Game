using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour
{
    public Transform target;

   private Vector3 offset3;

   public bool useOffsetValues;

   public float rotateSpeed;

   public Transform pivot;

    public float maxViewAngle;
    public float minViewAngle;

    public bool invertY;


    //Use this for initialization
    void Start()
    {
        offset3 = transform.position - target.position;
        // if (!useOffsetValues)
        // {
        //     offset = target.position - transform.position;
        // }

        // pivot.transform.position = target.transform.position;
        // //pivot.transform.parent = target.transform;
        // pivot.transform.parent = null;
        // Cursor.lockState = CursorLockMode.Locked;
    }//update is called once per frame
   
    void Update()
    {
        transform.position=target.position+offset3;
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
        // pivot.transform.position = target.transform.position;
        // //Get the X position of the mouse and rotate the target
        // float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        // pivot.Rotate(0, horizontal, 0);

        // //Get the Y position of the mouse and rotate the pivot
        // float vertical  = Input.GetAxis("Mouse Y") * rotateSpeed;
        // //pivot.Rotate(vertical,0,0);
        // if(invertY)
        // {
        //     pivot.Rotate(vertical, 0, 0);
        // }
        // else
        // {
        //     pivot.Rotate(-vertical, 0, 0);
        // }

        // // Limit up/down camera rotation
        // if(pivot.rotation.eulerAngles.x > maxViewAngle && pivot.rotation.eulerAngles.x < 180f)
        // {
        //     pivot.rotation = Quaternion.Euler(maxViewAngle, 0, 0);
        // }

        // if(pivot.rotation.eulerAngles.x > 180 && pivot.rotation.eulerAngles.x < 360f + minViewAngle)
        // {
        //     pivot.rotation = Quaternion.Euler(360f + minViewAngle, 0, 0);
        // }


        // float desiredXAngle = pivot.eulerAngles.x;
        // float desiredYAngle = pivot.eulerAngles.y;
        // Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        // transform.position = target.position - (rotation * offset);

        // // tranform.position = target.position - offset;

        // if(transform.position.y < target.position.y)
        // {
        //     transform.position = new Vector3(transform.position.x, target.position.y - .5f, transform.position.z);
        // }
        // transform.LookAt(target);
    }
}
