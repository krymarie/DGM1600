using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleHeight;

	private Transform paddleTrans;

	void Start () {
		paddleTrans = gameObject.GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//get mouse posistionm translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//keeps the paddle at the same height so it only moves side to side (overide verticle y position)
		mousePos.y = paddleHeight;
		//so paddle is in front of camera or else it will dissapear (override z depth position
		mousePos.z = 0;
		//apply setting and mods to paddle
		paddleTrans.position = mousePos;

		
	}
}
