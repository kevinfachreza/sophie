using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveController : MonoBehaviour {

	public Transform vrCamera;
	public float toggleAngle = 30.0f;
	public float speed = 3.0f;
	private bool moveForward;
	private AudioSource sound_footsteps;
	private bool playFootSteps;

	private CharacterController player;

	public GameObject powerPanelA;
	public GameObject powerPanelB;
	public GameObject powerPanelC;

	// Use this for initialization
	void Start()
	{
		player = GetComponent<CharacterController>();
		moveForward = false;
		sound_footsteps = GetComponent<AudioSource> ();
		playFootSteps = false;
	}

	// Update is called once per frame
	void Update()
	{
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			
			if (hit.collider.tag == "PowerPanel") {
				if (hit.distance < 1.5) {
					hit.transform.GetComponent<PowerPanelController> ().AllowIncreaseValue ();
				} else {
					hit.transform.GetComponent<PowerPanelController> ().DisallowIncreaseValue ();
				}
			} else {
				powerPanelA.GetComponent<PowerPanelController> ().DisallowIncreaseValue ();
				powerPanelB.GetComponent<PowerPanelController> ().DisallowIncreaseValue ();
				powerPanelC.GetComponent<PowerPanelController> ().DisallowIncreaseValue ();
			}
		}


		if (Input.GetMouseButtonDown (0)) {
			moveForward = !moveForward;
			playFootSteps = !playFootSteps;

			if(playFootSteps){
				sound_footsteps.Play ();
			}
			else {
				sound_footsteps.Pause ();
			}
		}



		if (moveForward) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);
			player.SimpleMove (forward * speed);
		} 



	
	}
}
