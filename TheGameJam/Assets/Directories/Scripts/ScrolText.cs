using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrolText : MonoBehaviour {

    RectTransform intro;

    float PosX = 0.0f;
    float PosY = 0.0f;
	public float scrollTime = 1.0f; 
	// Use this for initialization
	void Start () {
        intro = GetComponent<RectTransform>();

	}
	
	// Update is called once per frame
	void Update () {
	     PosY+= scrollTime; 
        intro.anchoredPosition = new Vector2(PosX,PosY);
	}
}
