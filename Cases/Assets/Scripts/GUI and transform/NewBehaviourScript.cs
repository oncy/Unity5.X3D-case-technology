using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	//public GameObject gameobj;
	//public GameObject name;
	//public GameObject tag;

	void Start () {
		//gameobj = Resources.Load("Cube") as GameObject;
		//name = GameObject.Find("Cube");
		//tag = GameObject.FindWithTag("tag1");

		//StartCoroutine (doThing ());
	}

	/*IEnumerator doThing(){
		//Debug.Log ("dothing");
		//yield return null;

		//yield return new WaitForSeconds (2);
		//Debug.Log ("do");

		yield return StartCoroutine (doThing2 ());
		yield return new WaitForSeconds (2);
		Debug.Log ("do1");
	}

	IEnumerator doThing2(){
		yield return new WaitForSeconds(2);
		Debug.Log ("do2");
	}*/

	void Update () {
		//Vector3 te = gameobj.transform.position;
		//te.y += 2 * Time.deltaTime;
		//gameobj.transform.position = te;

		//沿X轴移动
		transform.Translate (Text1.a * Time.deltaTime,0, 0);
		//GetComponent<Transform> ().Translate (1, 0, 0);

		//HelloWorld helloWorld = GetComponent<HelloWorld> ();
		//helloWorld.sayHello ();

		//transform.Find ("child").Translate (0, 2 * Time.deltaTime, 0);
		//transform.parent.Translate (0, 0, 2 * Time.deltaTime);

		//找到子对象hand，同时设置test中的变量a为2
		//transform.Find ("child").GetComponent<Text> ().a = 2;
		//transform.Find ("child").GetComponent<Text> ().doSomething ();
		//transform.Find ("child").GetComponent<Rigidbody> ().AddForce (0, 0, 2);

		//循环获取所有子对象，并且移动
		//foreach (Transform child in transform) {
		//	child.Translate (0, 5 * Time.deltaTime, 0);
		//}

		//name.transform.Translate (0, 0, 1);
		//tag.transform.Translate( 0 , 0 , 1 * Time.deltaTime);
		//name.GetComponent<Text>().doSomething;



	}

	/*
	    void OnTriggerStay(Collider other){
		//如果有刚体组件
		if (other.GetComponent<Rigidbody> ()) {
			other.GetComponent<Rigidbody> ().AddForce (2,0,0);
		}
	}
	*/


}
 