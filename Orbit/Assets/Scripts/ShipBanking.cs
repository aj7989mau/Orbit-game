using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBanking : MonoBehaviour
{
    void Start()
    {

    }

    public float rollSpeed;
    public GameObject rollCenter;

    void Update()
    {

        if (Input.GetKey("a"))
        {
            transform.RotateAround(rollCenter.transform.position, rollCenter.transform.right, -rollSpeed * Time.deltaTime);
        }

        else if (Input.GetKey("d"))
        {
            transform.RotateAround(rollCenter.transform.position, -rollCenter.transform.right, -rollSpeed * Time.deltaTime);
        }

        else
        {

        }

    }
}