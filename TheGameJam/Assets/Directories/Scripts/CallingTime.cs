using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallingTime : MonoBehaviour {


	public Slow_Mo timeManager; 

	void Update() 
	{

		if (Input.GetButtonDown ("Fire1")) {

			timeManager.DoSlowMotion (); 
		}

		if (Input.GetKey ("e")) 
		{

			timeManager.BreakSlowMotion (); 

		}


	}
}
