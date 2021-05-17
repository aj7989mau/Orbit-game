using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject EnemyStructure;
    float minSpawnTime = 10f;
    float maxSpawnTime = 20f;
    int randomSpawnMin = 0;
    int randomSpawnMax = 1999;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("BuildingSpawn", 10f);

        for (int i = 0; i < transform.childCount; i++)
        {
            if (Random.value <= 0.1)
            {
                GameObject newObj = Instantiate(EnemyStructure, transform.position, Quaternion.identity);
                newObj.transform.SetParent(this.transform.GetChild(i).transform);
            }

        }

    }

    void BuildingSpawn()
    {
        GameObject newObj = Instantiate(EnemyStructure, transform.position, Quaternion.identity);
        int randomSpawn = Random.Range(randomSpawnMin, randomSpawnMax);
        newObj.transform.SetParent(this.transform.GetChild(randomSpawn).transform);
        Debug.Log("Object Spawned" + this.transform.GetChild(randomSpawn).name);
        float randomTime = Random.Range(minSpawnTime, maxSpawnTime);
       
        Invoke("BuildingSpawn", randomTime);
    }
}
