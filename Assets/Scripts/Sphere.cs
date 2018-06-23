using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = new Vector3 (0, 0, -10);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
