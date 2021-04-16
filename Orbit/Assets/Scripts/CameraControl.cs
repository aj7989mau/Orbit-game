using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
	public float speed;
	float roll;
	float pitch;
	float yaw;

	void Update()
	{
		roll = Input.GetAxisRaw("Horizontal");
		pitch = Input.GetAxisRaw("Vertical");

		transform.Rotate(Vector3.up * roll * 100f * Time.deltaTime, Space.Self);
		transform.Rotate(Vector3.right * pitch * 100f * Time.deltaTime, Space.Self);

		if (Input.GetKey("space"))
		{
			transform.Translate(Vector3.forward * speed * Time.deltaTime);
		}
	}
}