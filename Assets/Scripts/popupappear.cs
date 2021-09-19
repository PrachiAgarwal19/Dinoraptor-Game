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

   void OnTriggerEnter(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           _popupapper.enabled = true;
           InputBox.ActivateInputField();
           Question.GetComponent<Canvas> ().enabled = true;

       }
   }
   void OnTriggerExit(Collider other)
   {
       if (other.CompareTag("Player"))
       {
           _popupapper.enabled = false;
           InputBox.DeactivateInputField();
           Question.GetComponent<Canvas> ().enabled = false;

       }
   }
}
