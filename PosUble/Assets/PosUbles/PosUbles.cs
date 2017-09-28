using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//adding above code allows me to animate code in UI

public class PosUbles : MonoBehaviour {

	public Text textBox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;


	// Use this for initialization
	void Start () 
	{
		guess = Random.Range (min, max);


		textBox.text = "Welcome to The Taco"
		+ "\nGuessing Game!"
		+ "\n\nPick a number of tacos in your head"
		+ "\n\nThe highest number you can pick is " + max
		+ "\nThe lowest number you can pick is " + min
		+ "\n\nIs the number of tacos you guessed higher or lower than " + guess
		+"\n\nUp arrow for higher, Down for lower, enter for equal";



		print ("Welcome to Number PosUbles");
		print ("Pick a number in your head");

		print ("The higheest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is the number higher or lower than " + guess);
		print ("Up arrow for higher, Down for lower, Enter for equal");
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();

		if (counter == -1) 
		{
		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) 
			{
				//counter--; moved below
				print ("You Win 5 Free Tacos!");
				textBox.text = "\nYou Win 5 Free Tacos!";
			}
		}

		else if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			min = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess;

		}
			

		else if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			max = guess;
			guess = (max + min) / 2;
			counter--;
			print ("Is the number higher or lower than " + guess);
			textBox.text = "Is the number higher or lower than " + guess;

		}



		if (Input.GetKeyDown (KeyCode.Return)) 
		{
			print ("You Lose It's Nacho Day!");
			textBox.text = "\nYou Lose It's Nacho Day!";
		}



		if (counter == 0)
		{
			counter--;
		}
					
	}
}