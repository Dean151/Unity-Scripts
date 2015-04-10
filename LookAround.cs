/**
  * LookAround.cs
  * Very simple script to use with a Camera and that allow rotating camera with the mouse
  * Created by Thomas Durand
  * 2015-04-10
  */

using UnityEngine;
using System.Collections;

public class LookAround : MonoBehaviour {
	// Horizontal and vertical aren't at the same sensibility
	private float horizontalFactor = 0.05f;
	private float verticalFactor = 2.5f;

	// Options that can be edited inside Unity Inspector
	public float sensibility = 1.0f;
	public bool inverseVertical = false;

	private void Start () {
		// Nothing to initialize \(^_^)/
	}
	
	// Update is called once per frame
	protected void Update () 
	{
		float invFactor = inverseVertical ? 1.0f : -1.0f;
		float v = sensibility * invFactor * verticalFactor * Input.GetAxis("Mouse Y");
		float h = sensibility * horizontalFactor 			 * Input.GetAxis("Mouse X");

		// Applying vertical rotation
		transform.Rotate (v, 0, 0);
		// Horizontal rotation around the vertical axis to avoid rolling
		transform.RotateAround(Vector3.up, h);
	}
}
