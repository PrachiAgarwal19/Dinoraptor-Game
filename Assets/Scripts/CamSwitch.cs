using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    private float num;

    void Start()
    {
        num=1;
        // cam1.SetActive(true);
        // cam2.SetActive(false);
        // cam3.SetActive(false);
        // cam4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(num==1){
            cam1.SetActive(true);
            cam2.SetActive(false);
            num=0;
        }
        
        if(Input.GetButtonDown("tab")){

            if(cam1.activeSelf){
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else if(cam2.activeSelf){
                cam1.SetActive(true);
                cam2.SetActive(false);
            }
        }
    }
}
