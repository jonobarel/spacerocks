﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.tag == "Asteroid") {
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {

	}
}
