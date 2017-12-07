using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	public float lifetime;
	public float speed;

	void Start () {
	}

	void Update () {

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {
			Destroy (this.gameObject);
		}
		//this is not too shabby but were going to try using the Unity Physics
		transform.Translate (Vector3.up * speed * Time.deltaTime);

	}
	//void OnCollisionEnter2D (Collision2D myCollider){
		if (health <= 0) {
			LevelManager.meteorCount--;
			levelManager.CheckMeteorCount ();
			Destroy (this.gameObject);

}
