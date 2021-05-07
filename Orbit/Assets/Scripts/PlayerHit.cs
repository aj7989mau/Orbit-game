using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public int health = 5;
    [SerializeField] private int mineDamage = 3;
    [SerializeField] private int missileDamage = 1;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag.Equals("Mine"))
        {
            health -= mineDamage;
        } else if (collider.tag.Equals("Missile"))
        {
            health -= missileDamage;
        } else
        {
            health -= 1;
        }
        if (health > 0)
        {
            //ToDo: Ta skada
            Debug.Log("You have taken damage. " + health + " life left!");
        } else
        {
            //ToDo: End screen?
            Debug.Log("You are dead. Game Over!");
        }
    }
}
