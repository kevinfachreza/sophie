using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class LampController : MonoBehaviour {


	public Light lt;
	public float decreaseValue;
	public float increaseValue;
	public bool allowDecrease;
	public bool allowIncrease;
	public Image health;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (allowDecrease) {
			lt.intensity = lt.intensity - decreaseValue;
		}

		if (allowIncrease) {
			if (lt.intensity <= 2) {
				lt.intensity = lt.intensity + increaseValue;
				allowDecrease = true;
			}
		}
		allowIncrease = false;
		health.fillAmount = lt.intensity/2;
	}

	public void AllowIncreaseValue()
	{
		allowIncrease = true;
	}
		
	public void DisallowIncreaseValue()
	{
		allowIncrease = false;
	}


}
