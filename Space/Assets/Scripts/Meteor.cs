using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meteor : MonoBehaviour {

	public float startingSpin;
	public int health;
	public Sprite []picture;
	private int count = 0;
	private LevelManager levelManager;
	public Animator animator;
	private GameObject scoreboard;
	public ScoreBoard scoreScript;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddTorque(Random.Range(startingSpin,-startingSpin),ForceMode2D.Impulse);
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}

	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away 1 health for that object only
		health--;
		count++;

		if (count > picture.Length - 1) {
			count--;
		}
		//if health is  <0 destroy meteor
		GetComponent<SpriteRenderer> ().sprite = picture [count];
		//change the picture
		if (health <= 0) {
			LevelManager.meteorCount--;
			levelManager.CheckMeteorCount ();
			Destroy (this.gameObject);
		}
	}
		//tyring to add a score board for how many meteors i destroy
	private void IncrementScore(){
		scoreboard.GetComponent<ScoreBoard> ().IncrementScoreboard (10);
	}

}

