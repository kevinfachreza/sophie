using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour {

	public Transform vrCamera;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	private bool moveForward;


	private CharacterController player;

	// Use this for initialization
	void Start()
	{
		player = GetComponent<CharacterController>();
		moveForward = false;
	}

	// Update is called once per frame
	void Update()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.tag == "Lamp") {
				print (hit.distance);
				if (hit.distance < 1.5) {
					Debug.Log ("There is Lamp");
					hit.transform.GetComponent<LampController> ().AllowIncreaseValue ();
				} else {
					hit.transform.GetComponent<LampController> ().DisallowIncreaseValue ();
				}
			}
		}


		if (Input.GetMouseButtonDown (0)) {
			moveForward = !moveForward;
		}



		if (moveForward )
		{
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);
			player.SimpleMove(forward * speed);
		}



	
	}
}
