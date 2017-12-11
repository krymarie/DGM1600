using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	[SerializeField]
	public static int meteorCount;
	public static int shipCount;//not sure if this will work
	public LevelManager myLevelManager;//think this will helo

	void Start (){

		meteorCount = FindObjectsOfType<Meteor> ().Length;
		//shipCount = FindObjectOfType<Ship> ().Length;//not sure
		//print (shipCount);
		//print (meteorCount);

	}

	public void LevelLoad (string name) {
		SceneManager.LoadScene (name);
	}

	public void ExitGame (){
		print ("Tried to Exit.");
		Application.Quit ();	
	}	

	public void LoadNextLevel () {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	
	}

	public void CheckShipCount (){
		if (shipCount <= 0) {
			myLevelManager.LevelLoad ("GameOver");
		}
	}

	public void CheckMeteorCount (){
		if (meteorCount <= 0) {
			LoadNextLevel ();
		}
		//print (meteorCount);
	}
}

