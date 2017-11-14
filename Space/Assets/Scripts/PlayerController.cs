using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float playerHeight;
	private Transform playerTrans;

	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;

	// Use this for initialization
	void Start () {

		playerTrans = gameObject.GetComponent<Transform> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//get mouse posistionm translating to world coordinates
		Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		//so paddle is in front of camera or else it will dissapear (override z depth position
		mousePos.z = 0;
		//apply setting and mods to paddle
		playerTrans.position = mousePos;

		if(Input.GetButtonUp("Fire1"))
		{
			GameObject shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D>().AddForce(shotPos.up * shotForce);
		}
			
				
	}
		
}

