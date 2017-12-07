using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {

	public enum Type {fancyDancy, myAwesomeness, laserButt};
	public Type powerupType;
	public Sprite[] images;

	// Use this for initialization
	void Start () {
		switch (powerupType) {
		case Type.myAwesomeness:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [0];
			break;
		case Type.laserButt:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [1];
			break;
		case Type.fancyDancy:
			gameObject.GetComponent<SpriteRenderer> ().sprite = images [2];
			break;
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log ("You hit something green!");

		if (powerupType == Type.myAwesomeness) {

		}

		switch (powerupType) {
		case Type.myAwesomeness:
		//	other.GetComponent<PlayerController> ().thrusterForce *= 2;
			break;
		default:
			break;


		}

	
		Destroy (this.gameObject);
	}
}
