using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public float orbitSpeed = 2f;
    public GameObject orbitCenter;
    public GameObject cameraObject;

    void Update()
    {
        transform.RotateAround(orbitCenter.transform.position, cameraObject.transform.forward, -orbitSpeed * Time.deltaTime);
    }
}