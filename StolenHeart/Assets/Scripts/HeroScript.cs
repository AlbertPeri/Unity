using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScript : MonoBehaviour {
	public float speed;
	public float jump = 100f;
	Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
		float moveX = Input.GetAxis ("Horizontal") * speed;
		rb.AddForce(new Vector2(moveX, 0));
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector2.up * jump);
		}
	}
}
