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

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Awake()
    {
        rigidBody = gameObject.GetComponent<Rigidbody>(); ;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    // Update is called once per frame
    void Update()
        
    {      
        if ((player.transform.position - rigidBody.position).magnitude < activationDistance) {
            audioSrc.Play();
            gameObject.GetComponent<Rigidbody>();
            Vector3 direction = player.transform.position - rigidBody.position;
            direction.Normalize();
            movementSpeed = Mathf.Max((movementSpeed + acceleration), maxMovementSpeed);
            rigidBody.velocity = direction * movementSpeed;
            
        }
    }
}
