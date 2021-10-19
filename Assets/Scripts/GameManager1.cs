using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager1 : MonoBehaviour
{
    public Text livecheck;
    public void Awake()
    {

        HealthManager.OnUpdate += ChangeLive;
        CanvasInput.OnUpdate += ChangeLive;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeLive(int live)
    {
        livecheck.text = "live: " + live + "!";
    }
}
