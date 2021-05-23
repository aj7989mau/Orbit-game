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
    private AudioSource audioSrc;


    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); ;
        player = GameObject.FindGameObjectWithTag("Player");
        audioSrc = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void FixedUpdate()
        
    {      
        if ((player.transform.position - rigidBody.position).magnitude < activationDistance) {
            if (!audioSrc.isPlaying)
            {
                audioSrc.Play();
            }
            Vector3 direction = player.transform.position - rigidBody.position;
            direction.Normalize();
            movementSpeed = Mathf.Max((movementSpeed + acceleration * Time.deltaTime), maxMovementSpeed) ;
            rigidBody.velocity = direction * movementSpeed;
            
        }
    }
}
