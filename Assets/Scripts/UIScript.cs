using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    [Header("Labels")]
    public Text moneyLabel;
    public Text scoreLabel;

    [Header("Icons")]
    [SerializeField] GameObject[] HullIcons;
    [SerializeField] GameObject[] ShieldIcons;
    [SerializeField] GameObject HealthBoostIcon;
    [SerializeField] GameObject ShieldBoostIcon;


    // Start is called before the first frame update
    void Start()
    {
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        moneyLabel.text = "Money: " + GameManager.Money;
        scoreLabel.text = "Score: " + GameManager.Score;
        UpdateIcons(ShieldIcons, GameManager.Shields);
        UpdateIcons(HullIcons, GameManager.Hull);
    }

    void UpdateIcons(GameObject[] GOs, int count)
    {
        int i = 0;
        foreach(GameObject go in GOs)
        {
            //Debug.Log(count);
            if (i < count)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
            i++;
        }

        if (GameManager.NumHealthBoosts > 0)
        {
            HealthBoostIcon.SetActive(true);
        }
        else
        {

            HealthBoostIcon.SetActive(false);
        }

        if (GameManager.NumShieldBoosts > 0)
        {
            ShieldBoostIcon.SetActive(true);
        }
        else
        {
            ShieldBoostIcon.SetActive(false);
        }
    }
}
