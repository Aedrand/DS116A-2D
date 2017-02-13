using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawn : MonoBehaviour {

    public GameObject prefab;
    public BoxCollider2D boxColLeft;
    public BoxCollider2D boxColRight;

	// Use this for initialization
	void Start () {
        Instantiate(prefab, new Vector3(boxColLeft
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
