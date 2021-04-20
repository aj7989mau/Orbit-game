using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    [SerializeField] private int health;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log(collision.name + " collided with " + this.name + ", apply player damage if needed.");
        }
        health--;
        if (health > 0)
        {
            Debug.Log(gameObject.name + " is hit! Needs " + health + " more hits to be destroyed");
        }
        else
        {
            Debug.Log(gameObject.name + " is destroyed");
            Destroy(this.gameObject);
        }
    }
}
