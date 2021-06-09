using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField]
    protected GameObject player;
    [SerializeField]
    protected GameObject Bananas;
    [SerializeField]
    protected float speed = 10f;
    protected float horizontalInput;
    protected float xRange = 16;

    //Make player stop when reaching a certain position
    public void stopPlayer()
    {
        if (player.transform.position.x > xRange)
        {
            player.transform.position = new Vector3(xRange, player.transform.position.y, player.transform.position.z);
        }
        else if (player.transform.position.x < -xRange)
        {
            player.transform.position = new Vector3(-xRange, player.transform.position.y, player.transform.position.z);
        }
    }

    //Throw foods into Animals
    public void throwFoods()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bananas, transform.position, Bananas.transform.rotation);
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        player.transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        stopPlayer();
        throwFoods();
    }

}
