using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPrefabScript : MonoBehaviour {
	public int i = 5;
	public int j = 0;
	public Rigidbody BallPrefab;
	public float x = 0.0f;
	public float y = 4.0f;
	public float z = 0.0f;
	public float k = 2.0f;
	public int n = 4;
	int count = 0;
	public Rigidbody[] BP;

	void Start () {
		BP = new Rigidbody[10];
		count = 0;
		for (i = 0; i <= n; i++) {
			for (j = 0; j < i; j++)
				BP [count++] = (Rigidbody)Instantiate (BallPrefab, new Vector3 (x-2.0f*k*i+4.0f*j*k,2.0f, z-2.0f*1.75f*k*i), BallPrefab.rotation);
		}
	}
	
	void Update () {
		
	}
}
