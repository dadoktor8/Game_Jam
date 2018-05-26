using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Intro : MonoBehaviour {

    [SerializeField] Image Fading;
    [SerializeField] Animator anim;
    [SerializeField] float IntroTime = 10.0f;
    [SerializeField] int Index = 2;
    [SerializeField] AudioSource IntroMusic;

    double musicVolume = 0.0f;

	// Use this for initialization
	void Start () {

        StartCoroutine(FadeTo() );
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator FadeTo()
    {
        yield return new WaitForSeconds(IntroTime);
        anim.SetBool("Fade", true);
        StartCoroutine(StartLevel() );
        
    }

    IEnumerator StartLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(Index);
    }
}
