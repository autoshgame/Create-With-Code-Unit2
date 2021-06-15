using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] protected GameObject player;
    [SerializeField] protected GameObject foods;
    
    protected float speed = 10f;
    protected float horizontalInput;
    protected float verticalInput;
    protected float xRange = 18f;
    protected float zRangeUp = 23f;
    protected float zRangeDown = -3f;
    protected float points = 0f;



    [SerializeField] protected Text playerPoints;


    //Make player stop when reaching a certain position
    public void stopPlayer()
    {
        if (player.transform.position.x > xRange)
        {
            player.transform.position = new Vector3(xRange, player.transform.position.y, player.transform.position.z);
        }
        if (player.transform.position.x < -xRange)
        {
            player.transform.position = new Vector3(-xRange, player.transform.position.y, player.transform.position.z);
        }
        if (player.transform.position.z > zRangeUp )
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, zRangeUp);
        }
        if( player.transform.position.z < zRangeDown)
        {
            player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, zRangeDown);
        }
    }

    //Throw foods into Animals
    public void throwFoods()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foods, new Vector3(this.transform.position.x, this.transform.position.y + 1.5f, this.transform.position.z + 1.5f), foods.transform.rotation);
        }
    }

    public void playerMoving()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        player.transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);
        player.transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime);
    }

    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        playerMoving();
        stopPlayer();
        throwFoods();
    }
    
    
    public void OnGUI()
    {
        playerPoints.text = points.ToString();
    }

}
