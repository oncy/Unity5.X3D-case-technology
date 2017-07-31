using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public static int guiDepth = 1;

	void Start () {
		
	}
	
	void Update () {
		
	}
	void OnGUI(){
	GUI.depth = guiDepth;
		if (GUI.RepeatButton (new Rect (Screen.width / 3 * 2, Screen.height / 2, Screen.width / 5, Screen.height / 5), "GoBack")) {
			guiDepth = 1;
			GUI1.guiDepth = 0;
		}
	}
}
