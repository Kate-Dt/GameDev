using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour {

	public static bool isInfo = false;
	public GameObject Panel;

	void Update() {
		if (Input.GetKeyDown (KeyCode.F1)) {
			if (isInfo)
				Show ();
			else
				Hide ();
		}
	}
	public void Show() {
		Panel.SetActive (true);
		isInfo = true;
	}
	public void Hide() {
		Panel.SetActive (false);
		isInfo = false;
	}
}
