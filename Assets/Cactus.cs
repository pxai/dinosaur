using UnityEngine;
using System.Collections;

public class Cactus : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// Another way of Accessing
		//GamePoints gamePoints = GameObject.FindObjectOfType(typeof(GamePoints)) as GamePoints;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.name == "dinosaur") {
			if (GamePoints.points > GamePoints.hiScorePoints) {
				GamePoints.hiScorePoints = GamePoints.points;
			}
			Debug.Log ("Game Over! points: " + GamePoints.points);
			Application.LoadLevel ("GameOver");
		}
	}
}
