using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenUrl : MonoBehaviour
{
    public string url;

    public void Open(){
        //Application.OpenURL(url,"_blank").focus();
        //Application.ExternalEval("window.open(\"http://www.unity3d.com\")");
        //Application.ExternalEval("window.open('https://www.hackerrank.com/room-1-infinity-code-a')");
        Application.ExternalEval("window.open('" + url + "', '_blank')");
    }
}
