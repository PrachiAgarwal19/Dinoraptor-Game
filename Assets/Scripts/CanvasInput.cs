using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasInput : MonoBehaviour
{
    public Button btnClick;
    public InputField answer;
    public GameObject human1;
    public AudioSource killSound;

    private void Start(){
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        Debug.Log("Input : " + answer.text);
        if(answer.tag == "Question Easy 1" && answer.text=="4"){
            killSound.Play();
            Debug.Log("correct answer");
            Destroy(human1);
        }
    }
}