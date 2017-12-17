using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PowerPanelController : MonoBehaviour {

	private float energy;
	private float decreaseValue;
	private float increaseValue;
	private bool allowDecrease;
	private bool allowIncrease;
	public Image health;


	// Use this for initialization
	void Start () {
		energy = 1.00f;
		decreaseValue = 0.0001f;
		increaseValue = 0.001f;
		allowDecrease = true;
		allowIncrease = false;


	}
	
	// Update is called once per frame
	void Update () {
		if (allowDecrease) {
			if (energy >= 0) {
				energy = energy - decreaseValue;
			}
		}

		if (allowIncrease) {
			if (energy <= 1) {
				energy = energy + increaseValue;
				allowDecrease = true;
			}
		}
		health.fillAmount = energy;
		allowIncrease = false;

	}

	public void AllowIncreaseValue()
	{
		allowIncrease = true;
	}

	public void DisallowIncreaseValue()
	{
		allowIncrease = false;
	}

	public float getEnergy()
	{
		return energy;
	}
}
