using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    protected float spawnLimitXLeft = -22;
    protected float spawnLimitXRight = 7;
    protected float spawnPosY = 30;
    protected float startDelay = 1.0f;
    protected float spawnInterval = 2.0f;

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball 
        int arrayIndex = Random.Range(0, 2);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[arrayIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    

}
