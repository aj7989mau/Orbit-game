using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollissionDetection : MonoBehaviour
{
    [SerializeField] private int damageToPlayer = 1;
    [SerializeField] private int health;
    private GameStats gameStats;
    public ParticleSystem fire = null;

    private void Awake()
    {
        gameStats = GameObject.Find("GameStats").GetComponent<GameStats>();
    }
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag.Equals("Player"))
        {
            gameStats.changeHealth(-damageToPlayer);
        }
        health--;
        if (health > 0)
        {
            Debug.Log(gameObject.name + " is hit! Needs " + health + " more hits to be destroyed");
        }
        else
        {
            Debug.Log(gameObject.name + " is destroyed");
            if (tag.Equals("ColObj"))
            {
                gameStats.changeEnemyBuildings(-1);
            }
            Instantiate(fire, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
