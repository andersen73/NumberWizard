using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
		
	void Start () {
		StartGame ();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess);
		print ("Up = Higher, Down = Lower, Enter for Equal");
		
		max = max + 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I WON!");
			StartGame ();
		}
	}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print("Higher or Lower than " + guess);
		print ("Up = Higher, Down = Lower, Enter for Equal");
	}
}
