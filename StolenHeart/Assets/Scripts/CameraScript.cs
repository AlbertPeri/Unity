using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public GameObject hero;
	void Start () {
		
	}

	void Update () {
		transform.position = new Vector3 (hero.transform.position.x, hero.transform.position.y, transform.position.z);
	}
}
