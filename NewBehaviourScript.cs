using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess; 

	void Start (){
		StartGame ();
	}
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		max = max + 1;

		print ("==========================================================");
		print ("welcome");
		print ("type any #");
	
		print ("highest pick is 1000"+ max);
		print ("lowest pick is 1" + min);
	
		print ("number lower" +guess);
		print ("up arrow for higher, down for lower, return for equal");
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess ();
		} else if (Input.GetKeyDown(KeyCode.Return)){
			print("Won");
			StartGame ();
		}
	}
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or Lower than" + guess);
		print ("Up = higher, down = lower, return = equal");
	}
}