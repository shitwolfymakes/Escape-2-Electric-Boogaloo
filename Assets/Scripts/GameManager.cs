using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public static int Money;

    public static int totHull;
    public static int totShields;
    public static int Hull;
    public static int Shields;

    public static int Level;

    public static int NumHealthBoosts;
    public static int NumShieldBoosts;
    public static float playerFireRate;

    private bool gameOver;
    private bool restart;

    private void Start()
    {
        gameOver = false;
        restart = false;
        Score = 0;
        Money = 50;
        totHull = Hull = 2;
        totShields = Shields = 2;
        Level = 1;
        NumHealthBoosts = 1;
        NumShieldBoosts = 1;
        playerFireRate = .4f;
    }

    private void Update()
    {
        if (restart)
        {
            Debug.Log("Implement Restart");
        }
        if (Hull <= 0)
        {
            Debug.Log("Dead");
            //GameOver();
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

    public void lowerHull()
    {
        if(Shields <= 0)
        {
            Hull--;
        }
        else
        {
            Shields--;
        }
    }

    public bool GetHullDown()
    {
        if(Hull <= 0)
        {
            return true;
        }
        return false;
        
    }

    public void BoostHull()
    {
        NumHealthBoosts--;
        StartCoroutine("HullUP");
    }

    IEnumerator HullUP()
    {
        Hull = 5;
        yield return new WaitForSeconds(3);
        if (totHull < Hull)
            Hull = totHull;
    }

    public void BoostShields()
    {
        NumShieldBoosts--;
        StartCoroutine("ShieldUP");
    }

    IEnumerator ShieldUP()
    {
        Shields = 5;
        yield return new WaitForSeconds(3);
        if (totShields < Shields)
            Shields = totShields;
    }

    public void GameOver()
    {
        gameOver = true;
        ChangeScene cs = new ChangeScene();
        cs.loadBusted();
    }
}
