using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsMoving : MonoBehaviour
{
    [SerializeField] protected GameObject animals;
    [SerializeField] protected float speed = 10f;
    protected float topBound = 23f;
    protected float downBound = -8f;
    protected float rightBound = 16f;
    protected float leftBound = -16f;

    public void clearAnimals()
    {
        if (animals.transform.position.z > topBound)
        {
            Destroy(animals);
            Debug.Log("Destroy Animals");
        }
        if (animals.transform.position.z < downBound)
        {
            Destroy(animals);
            Debug.Log("Destroy Animals");
        }
        if (animals.transform.position.x > rightBound)
        {
            Destroy(animals);
            Debug.Log("Destroy Animals");
        }
        if (animals.transform.position.x < leftBound)
        {
            Destroy(animals);
            Debug.Log("Destroy Animals");
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        animals.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        clearAnimals();
    }
}
