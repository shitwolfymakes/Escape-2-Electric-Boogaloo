using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScore : MonoBehaviour
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
        moneyText.text = "Money: " + GameManager.Money;
        scoreText.text = "Score: " + GameManager.Score;
        //increase money and score by collecting certain items.
    }
}
