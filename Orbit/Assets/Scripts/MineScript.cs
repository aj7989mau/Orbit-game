using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player)
        {
            Debug.Log("Player collided with mine, apply player damage. Mine destroyed.");
            Destroy(this.gameObject);
        } else
        {
            health--;
            Debug.Log("Mine hit by projectile! Needs " + health + " more hits to be destroyed");
        }
    }
}
