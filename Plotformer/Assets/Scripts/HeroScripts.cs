using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroScripts : MonoBehaviour {
	public float speed = 5f;
	public Rigidbody2D myRigit;
	public int scores =0;
	void Start () {
		myRigit = GetComponent<Rigidbody2D> ();
	}
	

	void Update () {
		
		float xMotion = Input.GetAxis ("Horizontal") * speed;
		float yMotion = Input.GetAxis ("Vertical") * speed;
		myRigit.AddForce (new Vector2(xMotion, yMotion));
	}

	private void OnTriggerEnter2D(Collider2D collision){
		if (collision.gameObject.tag == "gem") {
			scores++;
			Destroy (collision.gameObject);
			Debug.Log (scores);
		}
	}
}
