using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public bool isMoving = true;
    public float orbitSpeed = 2f;
    public float yawSpeed = 5f;
    public GameObject orbitCenter;
    public GameObject playerObject;

    void Update()
    {
        if (isMoving)
        {
            transform.RotateAround(orbitCenter.transform.position, playerObject.transform.forward, -orbitSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.RotateAround(orbitCenter.transform.position, playerObject.transform.position, -yawSpeed * Time.deltaTime);
        }

        else if (Input.GetKey("d"))
        {
            transform.RotateAround(orbitCenter.transform.position, -playerObject.transform.position, -yawSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown("space"))  // For testing, to be removed.
        {
            isMoving = !isMoving;
        }
    }
}