using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCalculation : MonoBehaviour
{
    // Start is called before the first frame update
 
    [SerializeField] protected float totalPoints = 0;
    [SerializeField] protected Text playerPoints;

    private void OnTriggerEnter(Collider other)
    {
        totalPoints += 1;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
