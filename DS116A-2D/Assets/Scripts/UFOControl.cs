using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UFOControl : MonoBehaviour {

    public float speed;
    //public Text countText;
    //public Text winText;
    //public Text timeText;

    private Rigidbody2D ufoBody;
    //private int timeCount;
    //private int count;

	// Use this for initialization
	void Start () {
        ufoBody = GetComponent<Rigidbody2D>();
        //count = 0;
        //winText.text = "";
        //setCountText();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHoriz, moveVert);
        ufoBody.AddForce(movement * speed);
	}
    /*
    void setCountText()
    {
        countText.text = "Collected: " + count.ToString() + "/12";

        if(count >= 12)
        {
            winText.text = "You Win!- ";
            GameObject[] objs = GameObject.FindGameObjectsWithTag("PickUp");
            foreach(GameObject target in objs)
            {
                GameObject.Destroy(target);
            }

        }
    }*/
}
