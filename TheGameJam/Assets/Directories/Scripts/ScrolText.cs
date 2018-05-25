using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UI;

public class ScrolText : MonoBehaviour {

    RectTransform intro;
    float PosX = 0.0f;
    float PosY = 0.0f;

	// Use this for initialization
	void Start () {
        intro = GetComponent<RectTransform>();
	}
	
	// Update is called once per frame
	void Update () {
        PosY++;
        intro.anchoredPosition = new Vector2(PosX,PosY);
	}
}
