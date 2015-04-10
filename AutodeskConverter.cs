/**
  * AutodeskConverter.cs
  * Allow to convert vectors between Autodesk and Unity standards
  * Created by Thomas Durand
  * 2015-04-10
  */

using UnityEngine;
using System;
using System.Collections;

public static class AutoDeskConverter {

	/**
	  * Convert a string like "x|y|z" to a Vector3
	  */
	public static Vector3 StringToVector3(string input)
	{
		string[] coords = input.Split("|"[0]); 
		if (coords.Length == 3) 
		{
			return new Vector3( 
					float.Parse(coords[0]),
					float.Parse(coords[1]),
					float.Parse(coords[2])
				);
		}
		else
		{
			Debug.LogError(input + "could not be casted to Vector3");
			return Vector3.zero;
		}
	}
	
	/**
	  * Convert a Vector3 from Autodesk Standard to Unity Standard
	  */
	public static Vector3 AutodeskToUnity(Vector3 input) 
	{
		// Y and Z axis are inversed in Unity
		return new Vector3( input.x , input.z , input.y );
	}

	/**
	  * Convert a Vector3 from Unity Standard to Autodesk Standard
	  */
	public static Vector3 UnityToAutodesk(Vector3 input) 
	{
		// Actually this function is just an Alias to clarify Source Code
		return AutodeskToUnity(input);
	}
}
