using UnityEngine;
using System.Collections;

/// <summary>
/// Spin the object at a specified speed
/// </summary>
public class SpinFree : MonoBehaviour 
{
	public bool spin;
	public float speed = 10f;
	////[HideInInspector]
	//public float direction = 1f;
	////[HideInInspector]
	//public float directionChangeSpeed = 2f;

	void Update() 
	{
		//if (direction < 1f) 
		//{
		//	direction += Time.deltaTime / (directionChangeSpeed / 2);
		//}

		if (spin) 
		{
			transform.Rotate(Vector3.up, speed * Time.deltaTime); 
		}
	}
}