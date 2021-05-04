using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombColliderScript : MonoBehaviour
{
    public GameObject Explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Explode();
        }
    }

    private void Explode()
    {
        GameObject fire = Instantiate(Explosion);
        fire.GetComponent<ParticleSystem>().Play();
    }
}
