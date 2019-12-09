using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Money;
    private bool gameOver;
    private bool restart;

    private void Start()
    {
        gameOver = false;
        restart = false;
        Score = 0;
        Money = 50;

    }

    private void Update()
    {
        if (restart)
        {
            Debug.Log("Implement Restart");
        }
    }

    public void IncreaseScore(int addToScore)
    {
        Score += addToScore;

    }

    public void IncrementMoney(int addToMoney)
    {
        Money += addToMoney;
    }

    public void GameOver()
    {
        gameOver = true;
    }


}
