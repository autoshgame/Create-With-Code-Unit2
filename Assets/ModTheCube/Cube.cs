using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    [SerializeField] Material cubeMaterial;
    [SerializeField] protected float speed = 10f;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.localScale = Vector3.one * 1.5f;

        //Material material = Renderer.material;
        
       //material.color = new Color(1.0f, 1.0f, 0.3f, 0.4f);
    }
    
    void Update()
    {
        transform.Rotate(20.0f * Time.deltaTime * speed, 0.0f, 0.0f);
    }
}
