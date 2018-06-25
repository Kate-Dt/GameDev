using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : ReactiveObstacle {

	private Rigidbody rb;
	// Use this for initialization
	protected override void OnPlayerHere () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3 (0, 0, -10);
	}
	
}
