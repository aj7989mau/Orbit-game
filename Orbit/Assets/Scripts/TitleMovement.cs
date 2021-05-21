using UnityEngine;
using System.Collections;

public class TitleMovement : MonoBehaviour
{
    public float orbitSpeed;
    public float exitSpeed;
    public GameObject orbitCenter;
    public GameObject titleObject;

    void Update()
    {
        transform.RotateAround(orbitCenter.transform.position, titleObject.transform.up, -orbitSpeed * Time.deltaTime);

        if (Input.GetKeyDown("space"))  
        {
            orbitSpeed = exitSpeed;
        }
    }
}