using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    public GameObject EnemyStructure;
    public GameObject EnemyStructure2;
    public GameObject EnemyStructure3;
    float minSpawnTime = 10f;
    float maxSpawnTime = 20f;
    int randomContinentMin = 0;
    int randomContinentMax;
    int randomContinent;
    int randomLand;
    // Start is called before the first frame update
    void Start()
    {

        randomContinentMax = transform.childCount -1;
        Debug.Log("Continent max: " + randomContinentMax);
        Invoke("BuildingSpawn", 10f);

        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.GetChild(i).childCount; j++)
            {
                if (Random.value <= 0.1)
                {
                    GameStats.changeEnemyBuildings(1);
                    if (Random.value <= 0.42) 
                    { 
                    GameObject newObj = Instantiate(EnemyStructure, transform.position, Quaternion.identity, transform.GetChild(i).GetChild(j).transform);
                    }

                    else if ((Random.value > 0.42) && (Random.value <= 0.85))
                    {
                        GameObject newObj = Instantiate(EnemyStructure2, transform.position, Quaternion.identity, transform.GetChild(i).GetChild(j).transform);
                    }

                    else
                    {
                        GameObject newObj = Instantiate(EnemyStructure3, transform.position, Quaternion.identity, transform.GetChild(i).GetChild(j).transform);
                    }
                }
            }

        }

    }

    void BuildingSpawn()
    {
        do {
            randomContinent = Random.Range(randomContinentMin, randomContinentMax);
            randomLand = Random.Range(0, (transform.GetChild(randomContinent).childCount - 1));
        }
        while (transform.GetChild(randomContinent).childCount == 0 || transform.GetChild(randomContinent).GetChild(randomLand).childCount > 0) ;

        GameObject newObj = Instantiate(EnemyStructure, transform.position, Quaternion.identity, transform.GetChild(randomContinent).GetChild(randomLand).transform);
        Debug.Log("Object Spawned on Continent " + transform.GetChild(randomContinent).name + ", Land " + transform.GetChild(randomContinent).GetChild(randomLand).name);
        GameStats.changeEnemyBuildings(1);
        float randomTime = Random.Range(minSpawnTime, maxSpawnTime);
       
        Invoke("BuildingSpawn", randomTime);
    }
}
