using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    [SerializeField] private float maxSpawnTime = 30f;
    [SerializeField] private float minSpawnTime = 10f;
    [SerializeField] private float minCoordinateOffset = -20f;
    [SerializeField] private float maxCoordinateOffset = 20f;
    [SerializeField] private GameObject mine;
    [SerializeField] private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("MineSpawn", 10f);
    }

    void MineSpawn()
    {
        float randomOffsetX = Random.Range(minCoordinateOffset, maxCoordinateOffset);
        float randomOffsetY = Random.Range(minCoordinateOffset, maxCoordinateOffset);
        float randomOffsetZ = Random.Range(minCoordinateOffset, maxCoordinateOffset);

        Vector3 futurePlayerPosition = player.transform.right * 350 + player.transform.up * -350;

        Vector3 center = new Vector3(0,0,0);

        Vector3 endPoint = new Vector3(futurePlayerPosition.x + randomOffsetX, futurePlayerPosition.y + randomOffsetY, futurePlayerPosition.z + randomOffsetZ);

        Vector3 direction = (endPoint - center).normalized;

        Vector3 spawnPosition = (350 * direction);

        GameObject.Instantiate(mine, spawnPosition, Quaternion.identity);


        float randomTime = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("MineSpawn", randomTime);
    }
}
