﻿using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

namespace DialogueBoxNEC{
public class DialogueManager : MonoBehaviour {

		private Queue<string> sentences;
		public Text nameText; 
		public Text dialogueText; 
	

	void Start () {

			sentences = new Queue<string> (); 
		
	}

		public void startDialogue(Dialogues dialogue)
		{
			nameText.text = dialogue.name; 

			sentences.Clear (); 
			foreach (string sentence in dialogue.sentences) {
			
				sentences.Enqueue (sentence); 
			
			}

			DisplayNextSentence (); 
		}

		public void DisplayNextSentence () 
		{
			if (sentences.Count == 0)
			{

				endDialogue();
				return; 

			}

			string sentence = sentences.Dequeue (); 
			{
				dialogueText.text = sentence; 

			}
		
		}
	
		void endDialogue()
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 

		}

}

}