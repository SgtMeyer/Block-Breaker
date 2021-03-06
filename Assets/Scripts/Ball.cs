﻿using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public Paddle paddle;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted){
			//lock the ball to the paddle
			this.transform.position = paddle.transform.position + paddleToBallVector;
		
			// On Left Click, send ball flying
			if (Input.GetMouseButtonDown(0)) {
				print ("Mouse Clicked");
				hasStarted = true;
				this.rigidbody2D.velocity = new Vector2 (2f, 10f);
			}
		}	
	}
}
