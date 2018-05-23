using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

namespace button{

public class GameStartBUTTON : MonoBehaviour {

		public void startGame(){
		
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 
		

		
		}

}
}