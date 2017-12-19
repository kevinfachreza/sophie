using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockController : MonoBehaviour {

	private float minute = 55;
	private float hour = 21;
	void Update(){
		minute += Time.deltaTime;
		if (minute > 59) {
			hour = hour + 1 ;
			minute = 00;
		}
		if (hour > 23) {
			hour = 0;
		}

	}
	private void OnGUI(){
		if (minute < 10) {
			GUI.Box (new Rect (10, 10, 40, 20), "" + hour.ToString ("0") + ":0" + minute.ToString ("0"));
		} else {
			GUI.Box (new Rect (10, 10, 40, 20), "" + hour.ToString ("0") + ":" + minute.ToString ("0"));
		}
	}

}
