using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasdpt : MonoBehaviour
{
    //Variables
    public float movespeed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {
        //Find the rigidbody on this script
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Get Input from WASD Keys
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        movement = new Vector2(moveX, moveY).normalized;
    }

    //Fixed Update is called on a fixed value of frames
    private void FixedUpdate()
    {
        //Move the player
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
