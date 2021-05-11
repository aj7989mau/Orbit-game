using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombGravity : MonoBehaviour
{
    private float speed = 5000f;
    public GameObject planet;

    // Update is called once per frame
    void Update()
    {
        Vector3.MoveTowards(this.transform.position, planet.transform.position, speed * Time.deltaTime);
    }
}
