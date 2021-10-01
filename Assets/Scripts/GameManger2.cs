﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager2 : MonoBehaviour
{
    public Text goldText;
    public void Awake()
    {
        GoldPickup.OnUpdate += ChangeScore;
        HurtPlayer.OnUpdate += ChangeScore;
        CanvasInput.OnUpdate += ChangeScore;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ChangeScore(int score)
    {
        goldText.text = "Score: " + score + "!";
    }
}