using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ComicStrip : MonoBehaviour
{
    public GameObject canvas1;
    public GameObject canvas2;
    public GameObject canvas3;
    public GameObject canvas4;

    // Start is called before the first frame update
    void Start()
    {
        canvas1.GetComponent<Canvas> ().enabled = true;
        canvas2.GetComponent<Canvas> ().enabled = false;
        canvas3.GetComponent<Canvas> ().enabled = false;
        canvas4.GetComponent<Canvas> ().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if((canvas1.GetComponent<Canvas> ().enabled == true) && (Input.GetButtonDown("tab"))){
            canvas1.GetComponent<Canvas> ().enabled = false;
            canvas2.GetComponent<Canvas> ().enabled = true;
        }
        else if((canvas2.GetComponent<Canvas> ().enabled = true) && (Input.GetButtonDown("tab"))){
            canvas2.GetComponent<Canvas> ().enabled = false;
            canvas3.GetComponent<Canvas> ().enabled = true;
        }
        else if((canvas3.GetComponent<Canvas> ().enabled = true) && (Input.GetButtonDown("tab"))){
            canvas3.GetComponent<Canvas> ().enabled = false;
            canvas4.GetComponent<Canvas> ().enabled = true;
        }
        else if((canvas4.GetComponent<Canvas> ().enabled = true) && (Input.GetButtonDown("tab"))){
            canvas4.GetComponent<Canvas> ().enabled = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
