using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveObstacle : MonoBehaviour
{
	protected bool active;
	public float offset = 50f;
	
	// Update is called once per frame
	void FixedUpdate () {
		if (!active)
		{
			if (Math.Abs(transform.position.z - PlayerMovement.current.rigidbody.position.z) < offset)
			{
				active = true;
				OnPlayerHere();
			}
		}
	}

	protected virtual void OnPlayerHere()
	{
		
	}
}
