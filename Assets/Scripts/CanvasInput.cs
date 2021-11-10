using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CanvasInput : MonoBehaviour
{
    public Button btnClick;
    public InputField answer;
    public GameObject human;
    public AudioSource killSound;
    public GameObject canvas;
    // public delegate void ScoreUpdate(int value);
    // public static event ScoreUpdate OnUpdate;
    public static int countQues=0;
    public GameObject incorrectCanvas;
    //public Button tryAgain;

    //public Text tryAgainText;

    private void Start(){
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        Debug.Log("Input : " + answer.text);
        if(answer.tag == "Question Easy 1" && answer.text == "4"){
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
         else if (answer.tag == "Question Medium 1" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Hard 1" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
            
        }
        else if (answer.tag == "Question Easy 2" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Medium 2" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Hard 2" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Easy 3" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Medium 3" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Hard 3" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Easy 4" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Medium 4" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Hard 4" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Easy 5" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Medium 5" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else if (answer.tag == "Question Hard 5" && answer.text == "4")
        {
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            Destroy(btnClick);
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            //OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues, GoldPickup.goldCoinNo);
        }
        else{
            //GameObject.Find("Player").GetComponent<PlayerController> ().enabled = true;
            //EditorUtility.DisplayDialog("Incorrect Answer","Oops! It is an incorrect answer.", "Try Again");
            incorrectCanvas.GetComponent<Canvas> ().enabled = true;

            //canvas.GetComponent<Canvas> ().enabled = false;
            //incorrectCanvas.SetActive(true);
            //tryAgain.onClick.AddListener(GetDisableOnClick);
            //tryAgainText.enabled=true;
            //canvas.GetComponent<Canvas> ().enabled = false;
            StartCoroutine(GetDisableOnClick(incorrectCanvas));
            answer.text = "";
            GoldPickup.score -= 10;
            //OnUpdate(GoldPickup.score);
        }
    }
    public void SuccessOver(int count, int coins)
    {
        if ((count >= 15) && (coins >= 51))
        {
            //OnUpdate(GoldPickup.score);
            StartCoroutine(ChangeScreens());

        }
    }
    IEnumerator ChangeScreens()
    {
        yield return new WaitForSeconds(0.5f);
        //OnUpdate(GoldPickup.score);
        SceneManager.LoadScene(5);
    }

    IEnumerator GetDisableOnClick(GameObject c){
        yield return new WaitForSeconds(0.75f);
        c.GetComponent<Canvas> ().enabled = false;
        popupappear.movespeed = 3;
        //canvas.GetComponent<Canvas> ().enabled = true;
        //canvas.GetComponent<Canvas> ().enabled = true;
        //StartCoroutine(DisableCanvas(incorrectCanvas));
    }
    // IEnumerator DisableText(Text c){
    //     yield return new WaitForSeconds(2);
    //     c.enabled=false;
    // }
    IEnumerator DisableCanvas( GameObject c)
    {
        yield return new WaitForSeconds(1);
        //OnUpdate(GoldPickup.score);
        c.SetActive(false);
    }
}
