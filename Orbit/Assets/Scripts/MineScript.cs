using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == player)
        {
            Debug.Log("Player collided with mine, apply player damage. Mine destroyed.");
            Destroy(gameObject);
        }
    }
}
