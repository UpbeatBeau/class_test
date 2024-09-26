using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wasd_Tran : MonoBehaviour
{
    //Variables
    public static Wasd_Tran instance;

    public float speed = 3f;

    public GameObject pl2;

    private bool spawn = true;

    //public GameManager gameManager;

    //Awake happens on spawn of an Item
    private void Awake()
    {
        pl2 = this.gameObject;
        //gameManager = FindObjectOfType<GameManager>();
        /*if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }*/
    }
    


    // Update is called once per frame
    void Update()
    {
        /*
        //Find the position of the object every frame and make a vector
       Vector2 pos = transform.position;

        //If I press right arrow move the position to the right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        //If I press left arrow move position to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }
        //If I press down arrow move position down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        //If I press up arrow move position
        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }

        transform.position = pos;*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Only spawn if true
        if (spawn)
        {
            spawn = false;
            if(collision.transform.tag == "Player")
            {
                //gameManager.sc_num++;
                GameManager.instance.sc_num++;
                var pos = new Vector2(Random.Range(-7, 7), Random.Range(-2, 3));
                Instantiate(pl2, pos, Quaternion.identity);

                //Destroy player
                Destroy(this.gameObject);
            }
            else if (collision.transform.tag == "Player3")
            {
                //gameManager.p3sc_num++;
                GameManager.instance.p3sc_num++;
                var pos = new Vector2(Random.Range(-7, 7), Random.Range(-2, 3));
                Instantiate(pl2, pos, Quaternion.identity);

                //Destroy player
                Destroy(this.gameObject);
            }
            
            //Spawn a new Player 2 at a random location
            

            spawn = true;
        }

    }
    //-10, 3 x 2, -4 y
}
