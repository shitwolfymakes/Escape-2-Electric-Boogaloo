using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject player;
    public GameObject sprinter;
    public GameObject average;
    public GameObject bombardeer;
    public GameObject tieFighter;

    private GameObject enemyToSpawn;
    private bool spawning;

    float randZ;
    Vector3 whereToSpawn;

    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    float levelLength;

    // Start is called before the first frame update
    void Start()
    {
        levelLength = 7.5f + 30f + (10 * GameManager.Level);
        spawnRate = 2f - (.05f * (GameManager.Level - 1));
        Debug.Log("Level length = " + levelLength + ", " + "Spawn rate = " + spawnRate);
        StartCoroutine("WaitToSpawn");
    }

    IEnumerator WaitToSpawn()
    {
        //wait for the first part of the song to finish before starting the spawning
        yield return new WaitForSeconds(7.5f);
        spawning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > levelLength)
        {
            ChangeScene cs = new ChangeScene();
            cs.loadHonestJohn();
        }
        if (Time.time > nextSpawn && spawning)
        {
            enemyToSpawn = determineEnemy();
            nextSpawn = Time.time + spawnRate;
            randZ = Random.Range(-5f, 5f);

            whereToSpawn = new Vector3(Random.Range(27f, 35f), 0.0f, randZ);

            Instantiate(enemyToSpawn, whereToSpawn, Quaternion.identity);
        }

    }

    GameObject determineEnemy()
    {
        int enemySpawnId = Random.Range(0, 100);
        if (enemySpawnId <= 44)
        {
            return average;
        }
        else if (enemySpawnId > 44 && enemySpawnId <= 84)
        {
            return sprinter;
        }
        else if (enemySpawnId > 84 && enemySpawnId <= 99)
        {
            return bombardeer;
        }
        else
        {
            return tieFighter;
        }

    }
}
