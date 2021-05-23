using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemiesLeft : MonoBehaviour
{
    public float enemiesLeft;
    public float enemiesLeftMax;

    public GameObject enemiesLeftUI;
    public Slider s;

    void Start()
    {
        enemiesLeft = enemiesLeftMax;
        s.value = calcEnemiesLeft();
    }

    void Update()
    {
        s.value = calcEnemiesLeft();

        if(enemiesLeft < enemiesLeftMax)
        {
            //
        }

        if(enemiesLeft <= 0)
        {
            //You win
        }

        if(enemiesLeft > enemiesLeftMax)
        {
            enemiesLeft = enemiesLeftMax;
        }

    }

    float calcEnemiesLeft()
    {
        return enemiesLeft / enemiesLeftMax;
    }

}
