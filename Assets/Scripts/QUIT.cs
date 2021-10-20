using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QUIT : MonoBehaviour
{
    // public delegate void ScoreUpdate(int value);
    // public static event ScoreUpdate OnUpdate;
    public void QuitGmae()
    {
        //OnUpdate(GoldPickup.score);
        SceneManager.LoadScene(6);
    }
}
