	using System.Collections;
	using UnityEngine;
using UnityEngine.SceneManagement; 


	namespace EnemyBasics{

	public class Enemy_AI : MonoBehaviour {

		public float FPS_targetDistance; 
		public float FPS_lookDistance;
		public float FPS_attackDistance; 
		public float enemyMovement; 
		public float damping; 
		public Transform FPS_player; 
		Rigidbody EnemyGuy; 
	


		void Start () 
		{
			
			EnemyGuy = GetComponent<Rigidbody> (); 
		}
		

		void FixedUpdate ()
		{
			FPS_targetDistance = Vector3.Distance (FPS_player.position,transform.position); 
			if (FPS_targetDistance < FPS_lookDistance) 
			{
				
				WhereISPlayer (); 
				Debug.Log ("Player Found"); 

			}

			if (FPS_targetDistance < FPS_attackDistance) {
				attackFunction (); 
				Debug.Log ("About to die"); 

				restart (); 

			} 
		}

		void WhereISPlayer ()
		{

			Quaternion rotation = Quaternion.LookRotation (FPS_player.position - transform.position);
			transform.rotation = Quaternion.Slerp (transform.rotation, rotation, Time.deltaTime * damping); 
		}

		void attackFunction()
		{
			EnemyGuy.AddForce (transform.forward * enemyMovement); 

		}
		void restart()
		{
			
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name); 
		}
	}

	}
