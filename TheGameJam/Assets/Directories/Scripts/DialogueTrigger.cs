using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DialogueBoxNEC{
	public class DialogueTrigger : MonoBehaviour {
		public Dialogues dialogue ;

		public  void TriggerDialogue(){
			FindObjectOfType<DialogueManager> ().startDialogue (dialogue); 

		} 

	}


}
