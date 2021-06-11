﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    [SerializeField] protected float lives = 3f;
    [SerializeField] protected Text NumberOfLives;
    private void OnTriggerEnter(Collider other)
    {
        lives--;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lives == 0)
        {
            Debug.Log("You are dead");
        }
    }
    private void OnGUI()
    {
        NumberOfLives.text = "Lives : " + lives.ToString();
    }
}
