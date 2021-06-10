using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected GameObject[] animals;
 
    void SpawnRandomAnimals()
    {
        int animalIndex;
        float spawnRangeX = 16;
        animalIndex = Random.Range(0, 7);
        Vector3 spawmPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);
        Instantiate(animals[animalIndex], spawmPosition, animals[animalIndex].transform.rotation);
    }
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", 0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        //SpawnRandomAnimals();
    }
}
