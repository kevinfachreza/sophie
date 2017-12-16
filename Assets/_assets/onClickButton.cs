using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClickButton : MonoBehaviour {

	float elapsed = 0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Time.deltaTime);

		elapsed += Time.deltaTime;
		if (elapsed >= 0.1f) {
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

			cube.transform.position = new Vector3(Random.Range(-10,10), 20, Random.Range(-10,10));
			Rigidbody cubeRigidbody = cube.AddComponent<Rigidbody> ();
			cubeRigidbody.mass = 5;
			cubeRigidbody.useGravity = true;
			elapsed = 0f;
		}
	}

	void onClick(){
				
	}
}
