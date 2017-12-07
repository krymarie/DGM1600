using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

	public float startingSpin;
	public int health;
	public Sprite []picture;
	private int count = 0;
	private LevelManager levelManager;
	public GameObject[] hearts;


	// Use this for initialization
	void Start () {
		ShowHearts ();
		GetComponent<Rigidbody2D> ().AddTorque(Random.Range(startingSpin,-startingSpin),ForceMode2D.Impulse);
		levelManager = GameObject.FindObjectOfType<LevelManager> ();


	}

	private void ShowHearts(){	
	//Turn hearts off
		for (int i = 0; i < hearts.Length; i++) {
		hearts[i].SetActive (false);
		}

		//Turn hearts on
		for (int i = 0; i < health; i++) {
			hearts[i].SetActive (true);
		}


	}

	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away 1 health for that object only
		health--;
		count++;

		if (count > picture.Length - 1) {
			count--;
		//switch statement set the image basde on health level
		}
		//if health is  <0 destroy meteor
		GetComponent<SpriteRenderer>().sprite = picture[count];
		//change the picture
		if (health <= 0) {
			LevelManager.shipCount--;
			levelManager.CheckShipCount ();
			Destroy (this.gameObject);

		}
		ShowHearts ();
		//on collision destroy laser...???so it doesn't go thru the meteor
	}

	public int GetHealth(){
		//awesome code of some sort

		return health;
	}




}