using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace endGame{
public class EndTrigger : MonoBehaviour {

		public float NextLevelTimer = 1f; 

		void OnTriggerEnter()
		{

			Invoke("nextLevel",NextLevelTimer); 

		}

		void nextLevel()
		{

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 


		}

}
}