using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject paddle;

	private bool playing = false;
	private Vector3 paddleToBallVector;//x,y,z
	private Rigidbody2D rigid;


	void Start () {
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rigid = this.GetComponent<Rigidbody2D> ();
	}
		
	void Update () {
		if (!playing) {

		this.transform.position = paddle.transform.position + paddleToBallVector;
		//this objects position is going to be the distance between the paddle and ball + the location of the Ball
		///if we click a button ball goes flying
		if(Input.GetMouseButtonDown(0)){
			//ball goes flying
			rigid.velocity = new Vector2 (3,20);
			//playing = true;
			playing = true;
			
		}
		}
	}
}
