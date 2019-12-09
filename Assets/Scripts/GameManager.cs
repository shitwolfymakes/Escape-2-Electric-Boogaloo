using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Money;
    public static int Hull;
    public static int Shields;
    public static int Level = 0;
    private bool gameOver;
    private bool restart;

    private void Start()
    {
        gameOver = false;
        restart = false;
        Score = 0;
        Money = 50;
        Hull = 2;
        Shields = 2;
    }

    private void Update()
    {
        if (restart)
        {
            Debug.Log("Implement Restart");
        }
        if (Hull <= 0)
        {
            GameOver();
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

    public void BoostHull()
    {
        Debug.Log("Not implemented");
    }

    public void BoostShields()
    {
        Debug.Log("Not implemented");
    }

    public void GameOver()
    {
        gameOver = true;
        ChangeScene cs = new ChangeScene();
        cs.loadBusted();
    }


}
