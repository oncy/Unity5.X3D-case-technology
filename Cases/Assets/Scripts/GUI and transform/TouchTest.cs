using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
	public GameObject ball;
	//上一次两个手指距离
	private float lastDis = 0;
	//摄像机距离球的距离
	private float cameraDis = -20;
	//缩放阻尼
	public float ScaleDump = 0.1f;

	void Start () {
		
	}
	
	void Update () {
		//触控
		if (Input.touchCount == 1) {
			//获取触控
			Touch t = Input.GetTouch (0);
			//手指移动中
			if (t.phase == TouchPhase.Moved) {
				//竖直旋转+水平旋转
				ball.transform.Rotate (Vector3.right, Input.GetAxis ("Mouse Y"), Space.World);
				ball.transform.Rotate (Vector3.up, -1 * Input.GetAxis ("Mouse X"), Space.World);
			}
		} 
		else if (Input.touchCount > 1) {
			Touch t1 = Input.GetTouch (0);
			Touch t2 = Input.GetTouch (1);
			//开始触控
			if (t2.phase == TouchPhase.Began) {
				lastDis = Vector2.Distance (t1.position, t2.position);
				//两个手指都在移动
			} else if (t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved) {
				//计算手指位置
				float dis = Vector2.Distance (t1.position, t2.position);
				//手指位置大于1
				if (Mathf.Abs (dis - lastDis) > 1)
					//设置摄像机到物体的距离
					cameraDis += (dis - lastDis) * ScaleDump;
				 //限制摄像机到物体的距离
				cameraDis = Mathf.Clamp(cameraDis,-40,-5);
				//备份
				lastDis = dis;
			}
		}
	}
	void LateUpdate(){
		//调整摄像机位置
		this.transform.position = new Vector3 (0, 0, cameraDis);
	}

	void OnGUI(){
		string s = string.Format ("Input.touchCount = {0}\ncameraDIS=\n{1}", Input.touchCount, cameraDis);
		GUI.TextArea (new Rect (0, 0, Screen.width / 10, Screen.height), s);
		if (GUI.Button (new Rect (Screen.width * 9 / 10, 0, Screen.width / 10, Screen.height / 10), "quit")) {
			Debug.Log ("quit");
			Application.Quit ();
		}
	}

}
