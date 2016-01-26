using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GamePoints : MonoBehaviour {
	public Text hiScore;
	public Text score;
	public static int hiScorePoints = 0;
	public static int points;

	// Use this for initialization
	void Start () {
		points = 0;
		if (GameResult.savedHiScore > 0) {
			hiScorePoints = GameResult.savedHiScore;
			hiScore.text = GameResult.savedHiScore.ToString();
		} 
	}
	
	// Update is called once per frame
	void Update () {
		points++;
		score.text = points.ToString();
	}


}
