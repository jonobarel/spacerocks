﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		gameObject.transform.Rotate(Vector3.forward*Random.Range(1,360));
 	  	gameObject.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.up*Random.Range(100f,200f));		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
