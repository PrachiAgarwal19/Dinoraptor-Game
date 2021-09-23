using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasInput1a : MonoBehaviour
{
    public Button btnClick;
    public InputField answer;
    public GameObject human1;
    public AudioSource killSound;
    public GameObject canvas;
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    private void Start(){
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        Debug.Log("Input : " + answer.text);
        if(answer.tag == "Question Easy 2" && answer.text == "4"){
            killSound.Play();
            Debug.Log("correct answer");
            
            Destroy(human1);
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
        }
    }

    IEnumerator DisableCanvas( GameObject c)
    {
        yield return new WaitForSeconds(1);
        c.SetActive(false);
    }
}
