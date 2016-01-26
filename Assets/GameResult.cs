using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameResult : MonoBehaviour {
	public static int savedHiScore = 0;
	// Use this for initialization
	void Start () {
		Text result = GameObject.Find ("GameResult").GetComponent<Text> ();
		result.text = "Points: " + GamePoints.points + " - Highest: " + GamePoints.hiScorePoints;
		savedHiScore = GamePoints.hiScorePoints;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
