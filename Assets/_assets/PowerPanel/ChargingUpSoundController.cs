using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargingUpSoundController : MonoBehaviour {

	private AudioSource soundChargingUp;
	private bool toggleSoundChargingUp;
	private bool prevToggle;

	// Use this for initialization
	void Start () {
		soundChargingUp = GetComponent<AudioSource> ();
		toggleSoundChargingUp = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (toggleSoundChargingUp && prevToggle) {
			soundChargingUp.Play ();
			print ("playSound");
		} else {
			soundChargingUp.Stop ();
			print ("stopSound");
		}

		prevToggle = toggleSoundChargingUp;

	}

	public void startCharging(){
		toggleSoundChargingUp = true;
	}

	public void exitCharging(){
		toggleSoundChargingUp = false;
	}
}
