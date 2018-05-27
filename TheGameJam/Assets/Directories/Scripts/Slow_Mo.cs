using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow_Mo : MonoBehaviour {


	public float slowDownFactor = 0.08f; 
	public float slowDownFloat = 2f; 

	void update()
	{
		Time.timeScale += (1f / slowDownFloat) * Time.unscaledDeltaTime;
		Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f); 


	}



         public void DoSlowMotion()
	{
		Time.timeScale = slowDownFactor; 
		Time.fixedDeltaTime = Time.timeScale * .08f; 


	}

	public void BreakSlowMotion()
	{

		Time.timeScale = 1f; 


	}

}
