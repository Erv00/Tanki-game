using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour {
	public int speed;
	public int rotationSpeed;
		// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			gameObject.transform.Translate (Vector3.forward * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.S)) {
			gameObject.transform.Translate (Vector3.back * speed * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.RotateAround(Vector3.up, -rotationSpeed*Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.RotateAround(Vector3.up, rotationSpeed*Time.deltaTime);
		}
	}
}