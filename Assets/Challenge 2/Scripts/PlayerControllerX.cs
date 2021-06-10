using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    [SerializeField] protected float spawnCorruptedTime = 2.0f;
    protected float touchTime = 0f;
    protected bool isFirstTime = true;

    //Make player not spawning space key
    void spawnDuration()
    {
        if (Input.GetKey(KeyCode.Space) && isFirstTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            touchTime = Time.time;
            isFirstTime = false;
        }
        if (Input.GetKey(KeyCode.Space) && Time.time - touchTime >= spawnCorruptedTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            touchTime = Time.time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        spawnDuration();
    }


}
