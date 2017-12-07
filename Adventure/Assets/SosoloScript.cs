using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SosoloScript : MonoBehaviour {


	public Text textObject;
	//**will be red "text' until linked to "using unityEngin.UI" above

	public enum States {start, snapchat, instagram, facebook, text, date1, date2, neither};
	//variables for states must be listed beofre referencing
	public States myState;

	public bool Date_1interested = false;
	public bool Date_2interested = false;

	void Start () {
		myState = States.start;
	}

	void Update () {
		if (myState == States.start) { State_start ();}
		if (myState == States.snapchat) { States_snapchat ();}
		if (myState == States.instagram) { States_instagram ();}
		if (myState == States.facebook) { States_facebook ();}
		if (myState == States.text) { States_text ();}
		if (myState == States.date1) { State_Date_1 ();}
		if (myState == States.date2) { State_Date_2 ();}
		if (myState == States.neither) { State_Neither ();}
	}

	void State_start (){
		textObject.text = "You are on a desert island. And, by that i mean you're single and have no dates lined up. " +
			"All you have is you're phone. On your phone you have 4 aps that you can use to  socialize. " +
			"\nWhich app would you like to open?" +
			"\n\n Press S for Snapchat, F for Facebook, I for Instagram, T for Text";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.text;
		}
	}
	void States_snapchat () {
		textObject.text = "Not very many men use Snapchat and you're not interested in a man who takes to many selfies anyways." +
			"\n\nPress F for Facebook, I for Instagram, T for Text";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.text;
		}
	}

	void States_instagram () {
		textObject.text = "Date_2 keeps liking your posts and is occasionally making comments. He just messaged you and asked for" +
		" your cell. He's probably going to ask you out." +
		"\n\nPress F for Facebook, S for Snapchat, T for Text";
		Date_1interested = true;

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.text;
		}
	}
	
	void States_facebook () {
		textObject.text = "Date_1 asks for you cell number. He's definity interested. " +
			"\n\n Press S for Snapchat, I for Instagram, T for Text";
		Date_2interested = true;

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.text;
		}
	}

	void States_text (){
		if (Date_1interested == false && Date_2interested == false) {
			textObject.text = "No one has asked you out. You need to socialize to get asked out. Yes, it's a double edge sword. " +
			"But you can do this." +
			"\n\n Press S for Snapchat, F for Facebook, I for Instagram";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		}
		
		else if (Date_1interested == true && Date_2interested == true){
			textObject.text = "You have a text from Date_1 and Date_2 asking you out. Who would you like to go on a date with? " +
				"\n\nPress 1 for Date_1, 2 for Date_2, N for neither";
		}
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.date1;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.date2;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			myState = States.neither;
		}


		else if (Date_1interested == true){
			textObject.text = "Date_1 has asked you out. What are going to do?" +
			"\n\nPress 1 for Date with Date_1, S for Snapchat, F for Facebook, I for Instagram";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		} else if (Input.GetKeyDown (KeyCode.Alpha1)) {
			myState = States.date1;
		}


		else if (Date_2interested == true){
			textObject.text = "Date_2 has asked you out. What are going to do?" +
			"\n\nPress 2 for Date with Date_2, S for Snapchat, F for Facebook, I for Instagram";
		}
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.snapchat;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.facebook;
		} else if (Input.GetKeyDown (KeyCode.I)) {
			myState = States.instagram;
		} else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			myState = States.date2;
		}
	}

	void State_Date_1 () {
		textObject.text = "Date_1 takes you out to lunch and talks about himself the whole time. The food is amazing but the" +
			" conversation is so one sided even a person in earshot could tell it's not going to well. " +
			"\n\nBetter luck next time.";

	}

	void State_Date_2 () {
		textObject.text = "Date_2 takes you out on a wonderful lunch date. You talk non stop about all of your favorite things " +
			"and have a ton in common. Who knows where you'll go from here, or weather or not you'll go on a second date. " +
			"Either way you are off the desert island of singleness for now. Way to put yourself out there and meet new people. " +
			"\n\nYou are a winner!";

	}

	void State_Neither () {
		textObject.text = "You may feel like you lost, but saying no to someone you're not interested in is better than " +
			"waisting their time and yours. " +
			"\n\nBetter luck next time.";

	}
		


	
}
