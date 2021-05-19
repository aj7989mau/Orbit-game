using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineFollow : MonoBehaviour
{
    private GameObject player;
    [SerializeField] private float acceleration;
    [SerializeField] private float maxMovementSpeed;
    [SerializeField] private int activationDistance;
    private float movementSpeed = 0;
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); ;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
        
    {
        Debug.Log((player.transform.position - rigidBody.position).magnitude);
        
        if ((player.transform.position - rigidBody.position).magnitude < activationDistance) {
            gameObject.GetComponent<Rigidbody>();
            Vector3 direction = player.transform.position - rigidBody.position;
            direction.Normalize();
            movementSpeed = Mathf.Max((movementSpeed + acceleration), maxMovementSpeed);
            Debug.Log("Why are we here?");
            rigidBody.velocity = direction * movementSpeed;
            
        }
        
    }
}
