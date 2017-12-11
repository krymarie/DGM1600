using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {

	public int score;
	public Text display;
	public Text highscoreDisplay;
	public Text prevScoreDisplay;

	// Score board code that i choose not to you. This game is about reaching the top level. 
	void Start () {
		score = 0;
		if (display != null) {
			display.text = score.ToString ();
		}
		if (highscoreDisplay != null) {
			highscoreDisplay.text = GetScore ().ToString ();
		}
		if (prevScoreDisplay != null) {
			prevScoreDisplay.text = PlayerPrefs.GetInt ("PrevScore").ToString ();
		}
	}

	public void IncrementScoreboard(int value){
		score += value;
		display.text = score.ToString();
	}
	
	public void SaveScore(){
		//check previous score to show new high score
		int oldScore = GetScore();
		PlayerPrefs.SetInt ("PrevScore", score);

		//if bet then show "new high score"
		if(score > oldScore)
		PlayerPrefs.SetInt ("HighScore", score);
	}

	public int GetScore(){
		return PlayerPrefs.GetInt ("HighScore");
	}

	public void OnDisable(){
		SaveScore ();
}

}
