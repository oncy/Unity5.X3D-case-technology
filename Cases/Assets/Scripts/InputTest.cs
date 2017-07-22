using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour {
	//public float speed = 10.0f;
	int fingerCount = 0;
	public float speed = 0.1f;
	void Start () {
		
	}
	
	void Update () {
		//if (Input.GetMouseButtonDown (0)) {
		//	Debug.Log (Input.mousePosition);
		//}
		//if (Input.anyKeyDown)
			//Debug.Log ("A key or mouse click has been detected");
		//Debug.Log (Input.mousePosition);
		//if (Input.inputString != "") {
		//	Debug.Log (Input.inputString);
		//}

		//Vector3 dir = Vector3.zero;
		//dir.x = -Input.acceleration.y;
		//dir.z = Input.acceleration.x;
		//若是获取的三维向量不是标准向量
		//if (dir.sqrMagnitude > 1)
		//	dir.Normalize ();
		//dir *= Time.deltaTime;
		//transform.Translate (dir * speed);

		//遍历每个触控点
		//foreach(Touch touch in Input.touches){
			//当前触控点不是结束状态且当前触控不是取消状态
		//	if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
		//		fingerCount++;
		//}
		//if (fingerCount > 0)
		//	print ("User has " + fingerCount + "finger(s) touching the screen");

		float moveX = Input.GetAxis ("Horizontal");
		float moveY = Input.GetAxisRaw ("Vertical");
		this.transform.Translate (new Vector3(moveX,moveY,0)*speed*Time.deltaTime);
		Debug.Log (moveX);
		Debug.Log (moveY);



	}

	void OnGUI(){
		//GUI.Button (new Rect (0, 0, Screen.width / 10, Screen.height / 10), "Fire");
	}
}
