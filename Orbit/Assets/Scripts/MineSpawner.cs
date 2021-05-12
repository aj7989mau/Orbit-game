using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    [SerializeField] private float maxSpawnTime = 30f;
    [SerializeField] private float minSpawnTime = 10f;
    [SerializeField] private float minCoordinateOffset = 10f;
    [SerializeField] private float maxCoordinateOffset = 20f;

    // Start is called before the first frame update
    void Start()
    {

        Invoke("MineSpawn", 10f);
    }

    void MineSpawn()
    {
        float randomTime = Random.Range(minSpawnTime, maxSpawnTime);
        float randomOffsetX = Random.Range(minCoordinateOffset, maxCoordinateOffset);
        float randomOffsetY = Random.Range(minCoordinateOffset, maxCoordinateOffset);
        float randomOffsetZ = -(randomOffsetX + randomOffsetY);

        //Uträkning för framtida position om vi inte använder gameObject

        transform.position = new Vector3(transform.position.x + randomOffsetX, transform.position.y + randomOffsetY, transform.position.z + randomOffsetZ);
        float radiusFactor = 350 / (transform.position.x + transform.position.y + transform.position.z);


        transform.position = new Vector3(transform.position.x*radiusFactor, transform.position.y*radiusFactor, transform.position.z*radiusFactor);



        Invoke("MineSpawn", randomTime);
    }
}
