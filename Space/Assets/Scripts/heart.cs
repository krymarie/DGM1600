using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour {

	public Animator animator;

	public void TriggerDeath(){
		animator.SetTrigger ("Heart_Die");

	}
	
	public void Die (){
		gameObject.SetActive (false);
		
	}
}
