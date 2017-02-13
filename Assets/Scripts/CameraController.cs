﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;  //Reference to player game object

    private Vector3 offset;    //Offset distance between player and camera

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// LateUpdate is called after Update each frame
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
