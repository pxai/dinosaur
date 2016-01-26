using UnityEngine;
using System.Collections;

public class Dinosaur : MonoBehaviour {
	private int speed= 20;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("Space was pressed");
			this.rigidbody2D.velocity = Vector2.up * speed;
		}
		this.transform.rotation = Quaternion.identity;
	}
}
