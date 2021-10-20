using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Success : MonoBehaviour
{
    public delegate void ScoreUpdate(int value);
    public static event ScoreUpdate OnUpdate;

    // Start is called before the first frame update
    void Start()
    {
        OnUpdate(GoldPickup.score);
        Debug.Log(GoldPickup.score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
