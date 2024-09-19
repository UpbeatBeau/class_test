using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasd_rb : MonoBehaviour
{
    //Variables. Declare your variables
    public float forceAmt = 10f;

    private int i = 8;
    
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
     //Find the Rigibody on the object this script is on
     rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If statement to move right on screen by using D
        if (Input.GetKey(KeyCode.D))
        {
            //Make the rigidbody move right
            rb.AddForce(Vector2.right * forceAmt);
        }
        // Make the rigidbody move left
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * forceAmt);
        }
        //Make the rigidbody move up with W
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector2.up * forceAmt);
        }
        //Make the rigidbody move down with S
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * forceAmt);
        }
    }

    //OnCollisionEnter2D happens when two 2D objects with Colliders hit each other
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Make the Cube change color when it hits player 2 cube
        if(collision.transform.tag == "Player2")
        {
            //Find the Color compent of the item and change it to cyan
            GetComponent<SpriteRenderer>().color = Color.cyan;
        }

        //Make the Cube Change color when it hits player 3 cube
        if(collision.transform.tag == "Player3")
        {
            GetComponent <SpriteRenderer>().color = Color.magenta;
        }

    }
  
}
