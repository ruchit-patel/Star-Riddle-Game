using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour {

	public Rigidbody2D starbody;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		starbody.velocity = new Vector2 (Input.GetAxisRaw ("Horizontal") * speed, Input.GetAxisRaw ("Vertical") * speed);
	}
}
