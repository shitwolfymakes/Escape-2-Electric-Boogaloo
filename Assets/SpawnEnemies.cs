using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject player;
    public GameObject sprinter;
    public GameObject average;
    public GameObject bombardeer;

    private GameObject enemyToSpawn;

    float randY;
    Vector2 whereToSpawn;

    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            enemyToSpawn = determineEnemy();
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-5f, 5f);

            whereToSpawn = new Vector2((Random.Range(20f, 27f)), randY);

            Instantiate(enemyToSpawn, whereToSpawn, Quaternion.identity);
        }
        
    } 

    GameObject determineEnemy()
    {
        int enemySpawnId = Random.Range(0, 100);
        if (enemySpawnId <= 50)
        {
             return average;
        }
        else if (enemySpawnId > 50 && enemySpawnId <= 85)
        {
          return sprinter;
        }
        else
        {
          return bombardeer;
        }
    
    }
}
