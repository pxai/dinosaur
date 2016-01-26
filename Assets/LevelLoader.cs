using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadLevel (string levelName) {
		Debug.Log ("Loading level: " + levelName);
		Application.LoadLevel (levelName);
	}

	public void loadEndLevel (string points) {
		Application.LoadLevel ("GameOver");
	}
}
