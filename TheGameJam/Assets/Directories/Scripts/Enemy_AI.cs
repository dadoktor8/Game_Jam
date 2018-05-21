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
		Renderer myRender; 


		void Start () 
		{
			myRender = GetComponent<Renderer>();
			EnemyGuy = GetComponent<Rigidbody> (); 
		}
		

		void FixedUpdate ()
		{
			FPS_targetDistance = Vector3.Distance (FPS_player.position,transform.position); 
			if (FPS_targetDistance < FPS_lookDistance) 
			{
				myRender.material.color = Color.yellow; 
				WhereISPlayer (); 
				Debug.Log ("Player Found"); 

			}

			if (FPS_targetDistance < FPS_attackDistance) {
				attackFunction (); 
				Debug.Log ("About to die"); 
				myRender.material.color = Color.red; 
				restart (); 

			} else 
			{
				myRender.material.color = Color.blue; 

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
