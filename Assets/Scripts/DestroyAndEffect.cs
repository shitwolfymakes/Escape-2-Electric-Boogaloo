using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndEffect : MonoBehaviour
{
    public GameObject effect;
    public GameObject playerDestroyed;
    public int scoreAmount;
    private GameManager gameManager;

    private void Start()
    {
        GameObject game = GameObject.Find("GameManager");
        if(game == null)
        {
            Debug.Log("Can't Find GameManager");
            return;
        }
        gameManager = game.GetComponent<GameManager>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Ship ship = gameObject.GetComponent<Ship>();
            if (ship != null)
            {
                Destroy(other.gameObject);
                gameManager.GameOver();
            }

            gameManager.lowerHull();

            if (gameManager.GetHullDown())
            {
                Instantiate(playerDestroyed, other.transform.position, other.transform.rotation);
            }
        }
        if (effect != null)
        {
            Instantiate(effect, other.transform.position, other.transform.rotation);
        }

        if (other.tag == "Enemy" )
        {
            return;
        }
        

        gameManager.IncreaseScore(scoreAmount);
        gameManager.IncrementMoney(scoreAmount / 2);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}