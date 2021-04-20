using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float orbitSpeed = 2f;
    public float yawSpeed = 5f;
    public GameObject orbitCenter;
	public GameObject playerObject;

    void Update()
    {
        transform.RotateAround(orbitCenter.transform.position, playerObject.transform.forward, -orbitSpeed * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            transform.RotateAround(orbitCenter.transform.position, playerObject.transform.position, -yawSpeed * Time.deltaTime);
        }

        else if (Input.GetKey("d"))
        {
            transform.RotateAround(orbitCenter.transform.position, -playerObject.transform.position, -yawSpeed * Time.deltaTime);
        }
    }
}