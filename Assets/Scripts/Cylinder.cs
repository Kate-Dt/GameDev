using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour {
	public Vector3 moveBy = new Vector3(0, 0, 0);
	public float speed = 10f;
	private Vector3 pointA;
	private Vector3 pointB;
	private bool going_to_b = true;
	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
		this.pointA = this.transform.position;
		this.pointB = this.pointA + moveBy;
		rb.velocity = new Vector3(speed*(moveBy.x>0 ? 1:-1), 0, 0);
	}

	// Update is called once per frame
	void Update () {
		if (isArrived ()) {
			rb.velocity *= -1;
			going_to_b = !going_to_b;
		}
	}

	void FixedUpdate () {
		
	}

	bool isArrived() {
		//Debug.Log ("Arrived!");
		Vector3 target = !going_to_b ? pointA : pointB;
		Vector3 pos = this.transform.position;
		target.y = target.z = pos.y = pos.z = 0;
		return Vector3.Distance(pos, target) < 0.5f;
	}
}
