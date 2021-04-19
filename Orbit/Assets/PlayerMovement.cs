using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public bool spin;
	public float speed = 1f;
	public GameObject target;

	void Update()
	{
		if (spin)
		{
			transform.RotateAround(target.transform.position, Vector3.forward, -speed * Time.deltaTime);
			//transform.Rotate(Vector3.up, speed * Time.deltaTime);
		}
	}
}