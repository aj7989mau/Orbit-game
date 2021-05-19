using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    [SerializeField] private int health;
    public ParticleSystem fire = null;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag.Equals("Player"))
        {
            Debug.Log(collider.name + " collided with " + this.name + ", apply player damage if needed.");
        }
        health--;
        if (health > 0)
        {
            Debug.Log(gameObject.name + " is hit! Needs " + health + " more hits to be destroyed");
        }
        else
        {
            Debug.Log(gameObject.name + " is destroyed");
            
            Instantiate(fire, transform.position, Quaternion.identity);
            Destroy(transform.parent.gameObject);
        }
    }
}
