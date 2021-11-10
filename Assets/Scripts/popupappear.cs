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
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = false;
           _popupapper.enabled = true;
           InputBox.ActivateInputField();
           Question.GetComponent<Canvas> ().enabled = true;
        }

        if(Question.GetComponent<Canvas> ().enabled == true){
            movespeed = 0;
        }
        
        if(other.CompareTag("West Wall(2)")){
            Vector3 lookf;
            lookf.x = 0f;
            lookf.y = 0;
            lookf.z = -360f;
            transform.rotation = Quaternion.LookRotation(lookf);
        }

        if(other.CompareTag("West Wall")){
            Vector3 lookb;
            lookb.x = 180f;
            lookb.y = 0;
            lookb.z = 0f;
            transform.rotation = Quaternion.LookRotation(lookb);
        }

        if(other.CompareTag("West Wall(3)")){
            Vector3 looke;
            looke.x = 0f;
            looke.y = 0;
            looke.z = 180f;
            transform.rotation = Quaternion.LookRotation(looke);
        }

        if(other.CompareTag("West Wall(1)")){
            Vector3 lookd;
            lookd.x = -180f;
            lookd.y = 0;
            lookd.z = 0;
            transform.rotation = Quaternion.LookRotation(lookd);
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
