using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodsMoving : MonoBehaviour
{
    [SerializeField]
    protected GameObject foods;
    [SerializeField]
    protected float speed = 10f;
    protected float topBound = 23f;


    private void clearFoods()
    {
        if(foods.transform.position.z > topBound)
        {
            Destroy(foods);
            Debug.Log("food is destroyed");
        }
    }







    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foods.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        clearFoods();
    }
}
