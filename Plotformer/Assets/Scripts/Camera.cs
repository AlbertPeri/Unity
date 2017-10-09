using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	public GameObject catPerson;

	void Start () {
		
	}
	

	void Update () {
		transform.position = new Vector3 (
			catPerson.transform.position.x,
			catPerson.transform.position.y,
			transform.position.z);
			
}
}