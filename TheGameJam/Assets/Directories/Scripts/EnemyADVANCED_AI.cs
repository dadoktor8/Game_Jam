using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
using UnityEngine.SceneManagement; 
namespace EnemyBasics{
public class EnemyADVANCED_AI : MonoBehaviour {


		public float lookRadius  = 10f; 

		Transform targetPlayer; 
		NavMeshAgent agent; 

	// Use this for initialization
	void Start () {
		
			agent = GetComponent<NavMeshAgent> (); 
			targetPlayer= PlayerManager.instance.player.transform; 

	}
	
	// Update is called once per frame
	void Update () {
		
			float distance = Vector3.Distance (targetPlayer.position , transform.position); 
			if (distance <= lookRadius)
			{

				agent.SetDestination (transform.position); 

                GetComponent<NPCSimplePatrol>().enabled = false;
				agent.SetDestination (targetPlayer.position); 

				faceTarget (); 

				if (distance <= agent.stoppingDistance) 
				{

					SceneManager.LoadScene (SceneManager.GetActiveScene ().name); 

				}
				
			}

	}

		void OnDrawGizmosSelected () 
		{

			Gizmos.color = Color.red; 
			Gizmos.DrawWireSphere (transform.position, lookRadius); 
		}


		void faceTarget()
		{
			Vector3 direction = (targetPlayer.position - transform.position).normalized; 
			Quaternion lookRotation = Quaternion.LookRotation (new Vector3 (direction.x, 0, direction.z)); 
			Quaternion.Slerp (transform.rotation,lookRotation, Time.deltaTime * 5f); 
		}



	}


}
