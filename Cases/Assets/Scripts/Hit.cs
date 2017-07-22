using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	public GameObject explosion;
	void Start () {
		
	}
	
	void Update () {
		
	}

	void OnCollisionEnter(){
		//撞击后1s后销毁对象
		Destroy (gameObject,1);
		//在原来对象的位置实例化一个损坏的物体
		transform.Translate(0 ,2 , 0);
		//GameObject theClonedExplosion = Instantiate (explosion, transform.position, transform.rotation) as GameObject;
	}
}
