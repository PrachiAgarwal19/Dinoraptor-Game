using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class popupappear : MonoBehaviour
{
   [SerializeField] 
   private Image _popupapper;
   [SerializeField] 
   private InputField InputBox;
   [SerializeField]
   private Canvas Question;
   public static int movespeed = 3;
    public Vector3 userDirection = Vector3.right;

    public void Update()
    {
        transform.Translate(userDirection * movespeed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           _popupapper.enabled = true;
           InputBox.ActivateInputField();
           Question.GetComponent<Canvas> ().enabled = true;
        }

        if(Question.GetComponent<Canvas> ().enabled == true){
            movespeed = 0;
        }
        
        if(other.CompareTag("West Wall(2)")){
            Vector3 lookForward;
            lookForward.x = 0f;
            lookForward.y = 0;
            lookForward.z = -360f;
            transform.rotation = Quaternion.LookRotation(lookForward);
        }

        if(other.CompareTag("West Wall")){
            Vector3 lookForward;
            lookForward.x = -360f;
            lookForward.y = 0;
            lookForward.z = 0;
            transform.rotation = Quaternion.LookRotation(lookForward);
        }

        if(other.CompareTag("West Wall(3)")){
            Vector3 lookForward;
            lookForward.x = 0f;
            lookForward.y = 0;
            lookForward.z = 360f;
            transform.rotation = Quaternion.LookRotation(lookForward);
        }

        if(other.CompareTag("West Wall(1)")){
            Vector3 lookForward;
            lookForward.x = 360f;
            lookForward.y = 0;
            lookForward.z = 0;
            transform.rotation = Quaternion.LookRotation(lookForward);
        }
    }
    void OnTriggerExit(Collider other)
    {
       if (other.CompareTag("Player"))
       {
           _popupapper.enabled = false;
           InputBox.DeactivateInputField();
           Question.GetComponent<Canvas> ().enabled = false;
           movespeed = 3;
       }
    }

    
}
