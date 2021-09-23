using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasInput : MonoBehaviour
{
    public AudioSource killSound;
    
    public Button btnClick1;
    public InputField answer1;
    public GameObject human1;
    public GameObject canvas1;

    public Button btnClick2;
    public InputField answer2;
    public GameObject human2;
    public GameObject canvas2;

public Button btnClick3;
    public InputField answer3;
    public GameObject human3;
    public GameObject canvas3;

public Button btnClick4;
    public InputField answer4;
    public GameObject human4;
    public GameObject canvas4;

    public InputField answer5;
    public GameObject human5;
    public GameObject canvas5;

    public InputField answer6;
    public GameObject human6;
    public GameObject canvas6;

    public InputField answer7;
    public GameObject human7;
    public GameObject canvas7;

    public InputField answer8;
    public GameObject human8;
    public GameObject canvas8;

    public InputField answer9;
    public GameObject human9;
    public GameObject canvas9;

    public InputField answer10;
    public GameObject human10;
    public GameObject canvas10;

    public InputField answer11;
    public GameObject human11;
    public GameObject canvas11;

    public InputField answer12;
    public GameObject human12;
    public GameObject canvas12;

    public InputField answer13;
    public GameObject human13;
    public GameObject canvas13;

    public InputField answer14;
    public GameObject human14;
    public GameObject canvas14;

    public InputField answer15;
    public GameObject human15;
    public GameObject canvas15;

    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    private void Start(){
        //btnClick1.onClick.AddListener(GetInputOnClickHandler);
        btnClick2.onClick.AddListener(GetInputOnClickHandler);
        //btnClick3.onClick.AddListener(GetInputOnClickHandler);
        //btnClick4.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        //Debug.Log("Input : " + answer.text);
        if(answer1.tag == "Question Easy 1" && answer1.text == "4"){
            //callFunc();
            //killSound.Play();
            Debug.Log("correct answer");
            Destroy(human1);
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas1));
        }
        else if(answer2.tag == "Question Medium 1" && answer2.text == "4"){
            //callFunc();
            //killSound.Play();
            Debug.Log("correct answer");
            Destroy(human2);
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas2));
        }
        else if(answer3.tag == "Question Hard 1" && answer3.text == "4"){
            //callFunc();
            //killSound.Play();
            Debug.Log("correct answer");
            Destroy(human3);
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas3));
        }
        else if(answer4.tag == "Question Easy 2" && answer4.text == "4"){
            callFunc();
            Destroy(human4);
            StartCoroutine(DisableCanvas(canvas4));
        }
        else if(answer5.tag == "Question Medium 2" && answer5.text == "4"){
            callFunc();
            Destroy(human5);
            StartCoroutine(DisableCanvas(canvas5));
        }
        else if(answer6.tag == "Question Hard 2" && answer6.text == "4"){
            callFunc();
            Destroy(human6);
            StartCoroutine(DisableCanvas(canvas6));
        }
        else if(answer7.tag == "Question Easy 3" && answer7.text == "4"){
            callFunc();
            Destroy(human7);
            StartCoroutine(DisableCanvas(canvas7));
        }
        else if(answer8.tag == "Question Medium 3" && answer8.text == "4"){
            callFunc();
            Destroy(human8);
            StartCoroutine(DisableCanvas(canvas8));
        }
        else if(answer9.tag == "Question Hard 3" && answer9.text == "4"){
            callFunc();
            Destroy(human9);
            StartCoroutine(DisableCanvas(canvas9));
        }
        else if(answer10.tag == "Question Easy 4" && answer10.text == "4"){
            callFunc();
            Destroy(human10);
            StartCoroutine(DisableCanvas(canvas10));
        }
        else if(answer11.tag == "Question Medium 4" && answer11.text == "4"){
            callFunc();
            Destroy(human11);
            StartCoroutine(DisableCanvas(canvas11));
        }
        else if(answer12.tag == "Question Hard 4" && answer12.text == "4"){
            callFunc();
            Destroy(human12);
            StartCoroutine(DisableCanvas(canvas12));
        }
        else if(answer13.tag == "Question Easy 5" && answer13.text == "4"){
            callFunc();
            Destroy(human13);
            StartCoroutine(DisableCanvas(canvas13));
        }
        else if(answer14.tag == "Question Medium 5" && answer14.text == "4"){
            callFunc();
            Destroy(human14);
            StartCoroutine(DisableCanvas(canvas14));
        }
        else if(answer15.tag == "Question Hard 5" && answer15.text == "4"){
            callFunc();
            Destroy(human15);
            StartCoroutine(DisableCanvas(canvas15));
        }
        else{
            Debug.Log("Incorrect ans");
            GoldPickup.score -= 10;
            OnUpdate(GoldPickup.score);
        }
    }

    private void callFunc(){
        killSound.Play();
        Debug.Log("correct answer");
        GoldPickup.score += 50;
        OnUpdate(GoldPickup.score);
    }

    IEnumerator DisableCanvas( GameObject c)
    {
        yield return new WaitForSeconds(1);
        c.SetActive(false);
    }
}
