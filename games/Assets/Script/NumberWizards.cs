using UnityEngine;
using System.Collections;

public class NumberWizards : MonoBehaviour {
	
	int max ;
	int min ;

	int guess  ;
	// Use this for initialization
	void Start () {
		gamestart ();
	}

	void gamestart (){
		
		int max = 1000;
		int min = 1;
		
		int guess =500 ;


		max += 1;
		// start once you begin the game 

		print (" ============================================================");

		
		print ("Number wizard game ");
		print (" pick a number you choose , do not tell us about it ");
		
		print (" the Higthest Number you can pick is " + max);
		
		print (" the lowestest Number you can pick is " + min);
		
		print (" is the Number is higher or lower than " + guess );
		print (" up = higher , down = lower , return = equal ");

	}


	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print (" up arrow is pressed ");
			min = guess;
			guessing();
		} 
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print (" down  arrow is pressed ");
			max = guess;
			guessing();
		}
			else if (Input.GetKeyDown(KeyCode.Return))
			print (" I won  ");
		Start ();
	}

	void guessing  (){
		guess = (max + min) / 2;
		print (" higher or lower than " + guess);
		
	}
	


}
