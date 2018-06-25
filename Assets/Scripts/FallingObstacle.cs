using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObstacle : ReactiveObstacle {
	
	protected override void OnPlayerHere()
	{
		var body = GetComponent<Rigidbody>();
		body.useGravity = true;
	}

}
