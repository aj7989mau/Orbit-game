using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LightMovement : MonoBehaviour
{

    public float lightMoveDelay;
    public float orbitSpeed;
    public float exitSpeed;
    public GameObject orbitCenter;
    public GameObject lightObject;

    void Update()
    {
        transform.RotateAround(orbitCenter.transform.position, lightObject.transform.up, -orbitSpeed * Time.deltaTime);
        StartCoroutine(MoveLight());
    }

    private IEnumerator MoveLight()
    {
        yield return new WaitForSeconds(lightMoveDelay);
        orbitSpeed = exitSpeed;
    }

}
