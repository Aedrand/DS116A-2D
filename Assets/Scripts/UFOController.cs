using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UFOController : MonoBehaviour
{

    public float speed;             //Floating point variable to store the player's movement speed.
    public Text countText;
    public Text winText;
    public Text timerText;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private int count;
    private int timer;

    private int interval = 1;
    private float nextTime = 0;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();

        count = 0;
        timer = 0;
        winText.text = "";
        timerText.text = 0 + " seconds";
        SetCountText();

        
    }

    private void Update()
    {
        if(Time.time >= nextTime)
        {
            if(count < 12)
            {
                timer++;
                timerText.text = timer.ToString() + " seconds";
                nextTime += interval;
            }
           
        }
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
