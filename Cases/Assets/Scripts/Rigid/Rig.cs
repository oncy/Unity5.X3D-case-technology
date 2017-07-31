using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rig : MonoBehaviour {

	void Start () {
		//GetComponent<Rigidbody> ().angularVelocity = Vector3.up;
		//GetComponent<Rigidbody> ().velocity = Vector3.up;
		//GetComponent<Rigidbody> ().detectCollisions = false;
		//修改惯性张量、惯性张量旋转
		//GetComponent<Rigidbody> ().inertiaTensor = Vector3.one;
		//GetComponent<Rigidbody> ().inertiaTensorRotation = Quaternion.identity;
		//GetComponent<Rigidbody> ().maxAngularVelocity = 1.9f;
		//最大穿透速度
		//GetComponent<Rigidbody> ().maxDepenetrationVelocity = 1.9f;
		//Debug.Log (GetComponent<Rigidbody2D> ().rotation);
		//GetComponent<Rigidbody>().AddForce(new Vector3(0,-1,0));

	}

	void FixedUpdate(){
		//在指定点施加力
		//GetComponent<Rigidbody> ().AddForceAtPosition (Vector3.one, transform.position, ForceMode.Force);
	}
	
	void Update () {
		//GetComponent<Rigidbody> ().MovePosition (transform.position + Vector3.right * Time.deltaTime);
		//施加力、相对力
		//GetComponent<Rigidbody>().AddForce(new Vector3(0,0.2f,0));
		//GetComponent<Rigidbody>().AddRelativeForce(Vector3.down,ForceMode.Force);
		//爆炸力
		//GetComponent<Rigidbody>().AddExplosionForce(19.0f,transform.position,10,1.5f,ForceMode.Force);
		//力矩、相对力矩
		//GetComponent<Rigidbody>().AddTorque(Vector3.down,ForceMode.Force);
		//GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(0,1.5f,0),ForceMode.Force);
		//刚体最近点
		//Debug.Log(GetComponent<Rigidbody>().ClosestPointOnBounds(Vector3.zero));
		//Debug.Log(GetComponent<Rigidbody>().GetPointVelocity(Vector3.up));
		//Debug.Log(GetComponent<Rigidbody>().GetRelativePointVelocity(Vector3.up));
		//GetComponent<Rigidbody>().Sleep();
		//GetComponent<Rigidbody> ().WakeUp ();
		//扫面检测所有
		//Debug.Log(GetComponent<Rigidbody>().SweepTestAll(Vector3.forward,10.0f).Length);

	}
}
