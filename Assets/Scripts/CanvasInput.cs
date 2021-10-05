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
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;
    private static int countQues=0;
    public GameObject incorrectCanvas;
    //public Button tryAgain;

    //public Text tryAgainText;

    private void Start(){
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    public void GetInputOnClickHandler(){
        Debug.Log("Input : " + answer.text);
        if(answer.tag == "Question Easy 1" && answer.text == "4"){
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
         else if (answer.tag == "Question Medium 1" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Hard 1" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Easy 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Medium 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Hard 2" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Easy 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Medium 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Hard 3" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Easy 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Medium 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Hard 4" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Easy 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 50;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Medium 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 60;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else if (answer.tag == "Question Hard 5" && answer.text == "4")
        {
            killSound.Play();
            Debug.Log("correct answer");
            GoldPickup.score += 70;
            OnUpdate(GoldPickup.score);
            StartCoroutine(DisableCanvas(canvas));
            Destroy(human);
            popupappear.movespeed = 3;
            countQues++;
            SuccessOver(countQues);
        }
        else{
            //EditorUtility.DisplayDialog("Incorrect Answer","Oops! It is an incorrect answer.", "Try Again");
            incorrectCanvas.GetComponent<Canvas> ().enabled = true;

            //canvas.GetComponent<Canvas> ().enabled = false;
            //incorrectCanvas.SetActive(true);
            //tryAgain.onClick.AddListener(GetDisableOnClick);
            //tryAgainText.enabled=true;
            //canvas.GetComponent<Canvas> ().enabled = false;
            StartCoroutine(GetDisableOnClick(incorrectCanvas));
            GoldPickup.score -= 10;
            OnUpdate(GoldPickup.score);
        }
    }
    public void SuccessOver(int count)
    {
        if (count== 15)
        {
            StartCoroutine(ChangeScreens());

        }
    }
    IEnumerator ChangeScreens()
    {
        yield return new WaitForSeconds(0.5f);

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
        c.SetActive(false);
    }
}
