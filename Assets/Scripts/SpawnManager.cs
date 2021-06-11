using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected GameObject[] animals;
 
    void SpawnRandomUpAnimals()
    {
        int animalIndex;
        float spawnRangeX = 22;
        animalIndex = Random.Range(0, animals.Length - 1);
        Vector3 spawnPositionX = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 23);
        Instantiate(animals[animalIndex], spawnPositionX, animals[animalIndex].transform.rotation);
    }
    void SpawnRandomleftAndRightAnimals()
    {
        int animalIndex; 
        float spawnRangeZUp = -4f;
        float spawnRangeZDown = 25f;
        var xAxisPlacelist = new List<int> { -17, 17 };
        int arrayIndex = Random.Range(0, xAxisPlacelist.Count);
        animalIndex = Random.Range(0, animals.Length - 1);
        Vector3 spawnPositionZ = new Vector3(xAxisPlacelist[arrayIndex], 0, Random.Range(spawnRangeZDown, spawnRangeZUp));
        Instantiate(animals[animalIndex], spawnPositionZ, animals[animalIndex].transform.rotation * Quaternion.Euler(0, Random.Range(-90, 90), 0));
    }

    void Start()
    {
        InvokeRepeating("SpawnRandomUpAnimals", 0.5f, 0.5f);
        InvokeRepeating("SpawnRandomleftAndRightAnimals", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
