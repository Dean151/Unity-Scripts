/**
  * LookAround.cs
  * Very simple script to make a free flying camera
  * Created by Thomas Durand
  * 2015-04-10
  */

using UnityEngine;
using System.Collections;

public class FreeCamera : LookAround {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	new protected void Update () {
		base.Update();

		if (Input.GetKey("w") || Input.GetKey("up")) 
		{
			transform.Translate(Vector3.forward);
		}

		if (Input.GetKey("s") || Input.GetKey("down")) 
		{
			transform.Translate(Vector3.back);
		}

		if (Input.GetKey("a") || Input.GetKey("left")) 
		{
			transform.Translate(Vector3.left);
		}

		if (Input.GetKey("d") || Input.GetKey("right")) 
		{
			transform.Translate(Vector3.right);
		}
	}
}
