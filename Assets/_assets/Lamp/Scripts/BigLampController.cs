using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigLampController : MonoBehaviour {

	private Light lt;
	public GameObject panel1;
	public GameObject panel2;
	public GameObject panel3;
	private float energy1;
	private float energy2;
	private float energy3;
	public float intensityMax;
	private AudioSource soundChargingUp;

	void Start () {
		lt = GetComponent<Light> ();
		soundChargingUp = GetComponent<AudioSource> ();
	}

	// Update is called once per frame
	void Update () {

		energy1 = panel1.GetComponent<PowerPanelController> ().getEnergy ();

		if (panel2) {
			energy2 = panel2.GetComponent<PowerPanelController> ().getEnergy ();
			if (panel3) {
				//IF ENERGY PANEL ONLY 3

				energy3 = panel3.GetComponent<PowerPanelController> ().getEnergy ();
				lt.intensity = (energy1 + energy2 +energy3) / 3 * intensityMax;

			} else {
				//IF ENERGY PANEL ONLY 2
				lt.intensity = (energy1 + energy2) / 2 * intensityMax;
			}


		} else {
			//IF ENERGY PANEL ONLY 1
			lt.intensity = energy1 * intensityMax;
		}



	}


}
