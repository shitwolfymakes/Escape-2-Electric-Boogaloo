﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text scoreText;
    public Text moneyText;
    public static int level = 1;
    public static int score;
    public static int money;
    public bool flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = 0;
        money = 0;
        scoreText.text = "Score: " + score;
        moneyText.text = "Money: " + money;

        //increase money and score by collecting certain items.
    }
}
