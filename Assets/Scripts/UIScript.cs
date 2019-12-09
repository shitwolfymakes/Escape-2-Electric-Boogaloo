using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Text moneyLabel;
    public Text scoreLabel;
    [SerializeField] GameObject[] ShieldIcons;
    [SerializeField] GameObject[] HullIcons;

    // Start is called before the first frame update
    void Start()
    {
        moneyLabel.text = "Money: " + GameManager.Money;
        scoreLabel.text = "Score: " + GameManager.Score;
    }

    // Update is called once per frame
    void Update()
    {
        moneyLabel.text = "Money: " + GameManager.Money;
        scoreLabel.text = "Score: " + GameManager.Score;
    }
}
