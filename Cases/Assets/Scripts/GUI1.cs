using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI1 : MonoBehaviour {
	public GUISkin[] gskin;
	public int skin_Index = 0;
	public string stringToEdit = "Modifyme.";
	public bool allOptions = true;
	public bool extended1 = true;
	public bool extended2 = true;
	public string lastTooltip = " ";
	public static int guiDepth = 0;

	void Start () {
		
	}
	
	void Update () {
		/*if(Input.GetKeyDown(KeyCode.Space))
			{
			skin_Index++;
			if(skin_Index >= gskin.Length){
				skin_Index = 0;
			}
		}*/
	}
	void OnGUI(){
		/*GUI.skin = gskin [skin_Index];
		if (GUI.Button (new Rect (0, 0, Screen.width / 10, Screen.height / 10), " a button")) {
		    Debug.Log("Button has been passed");
		}
		GUI.Label (new Rect (0, Screen.height * 3 / 10, Screen.width / 10, Screen.height / 10), "a lable");*/

		//GUI.color = Color.yellow;
		//GUI.Label (new Rect (Screen.width / 10 ,Screen.height /10 , Screen.width /5 ,Screen.height /10) , "Hello World");
		//GUI.Box (new Rect (Screen.width / 10, Screen.height / 5, Screen.width / 5, Screen.height / 5), "A Box");
		//GUI.Button (new Rect (Screen.width / 10, Screen.height / 2, Screen.width / 5, Screen.height / 10), "A Botton");


		GUI.backgroundColor = Color.yellow;
		GUI.Box (new Rect (Screen.width / 5, Screen.height / 7, Screen.width / 7*4, Screen.height / 4),new GUIContent("Box","this Box has a tooltip"));
		GUI.Button (new Rect (Screen.width / 4, Screen.height / 5, Screen.width / 5, Screen.height / 10), new GUIContent( "Click me","This is a tooltip"));
		GUI.Label (new Rect (Screen.width / 4 , Screen.height / 7, Screen.width / 5, Screen.height / 10), GUI.tooltip);

		GUI.backgroundColor = Color.green;
		GUI.contentColor = Color.blue;
		GUI.Button (new Rect (Screen.width / 2, Screen.height / 5, Screen.width / 5, Screen.height / 10), "A Botton");

		GUI.contentColor = Color.white;
		//绘制一个单行文本编辑框，并将值赋给变量stringToEdit
		stringToEdit = GUI.TextField(new Rect (Screen.width / 4, Screen.height / 2, Screen.width / 5, Screen.height / 10), stringToEdit,25);
		if (GUI.changed) {
			Debug.Log ("changed");
		}

		//在自定义区域绘制一个名为Edit All Options的开关，初始状态为allOptions
		allOptions = GUI.Toggle(new Rect (0, 0, Screen.width / 5, Screen.height / 10),allOptions,"Edit All Options");
		GUI.enabled = allOptions;
		extended1 = GUI.Toggle(new Rect (Screen.width / 20,  Screen.height / 10, Screen.width / 5, Screen.height / 10),extended1,"Extended Option1");
		extended2 = GUI.Toggle(new Rect (Screen.width / 20,  Screen.height / 5, Screen.width / 5, Screen.height / 10),extended2,"Extended Option2");
		GUI.enabled = true;
		//绘制一个OK按钮
		if (GUI.Button (new Rect (0, Screen.height * 3 / 10, Screen.width / 8, Screen.height / 20), "ok"))
			print ("user clicked ok");
        

		//GUILayout.Button (new GUIContent ("Play Game", "Button1"));
		//GUILayout.Button (new GUIContent ("Quit", "Button2"));
		//对当前事件进行锁定
		//if (Event.current.type == EventType.Repaint && GUI.tooltip != lastTooltip) {
		//	if (lastTooltip != "") 
		//		SendMessage (lastTooltip + "OnMouseOUT", SendMessageOptions.DontRequireReceiver);
		//	if (GUI.tooltip != "") 
		//		SendMessage (GUI.tooltip + "OnMouseOver", SendMessageOptions.DontRequireReceiver);
		//	lastTooltip = GUI.tooltip;
		//}


		GUI.depth = guiDepth;
		if (GUI.RepeatButton (new Rect (Screen.width / 2, Screen.height / 2, Screen.width / 5, Screen.height / 5), "GoBack")) {
			guiDepth = 1;
			Test.guiDepth = 0;
		}
   }

	void Button1OnMouseOver(){
		Debug.Log ("Play game got focus");
	}

	void Button2OnMouseOut(){
		Debug.Log ("Quit lost focus");
	}

}
