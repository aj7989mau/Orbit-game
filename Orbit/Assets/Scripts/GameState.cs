using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] private static int playerHealth = 5;
    private static int enemyBuildings = 0;

    static public void changeHealth(int change)
    {
        playerHealth += change;
        Debug.Log("Player health: " + playerHealth);
        if (playerHealth < 1)
        {
            gameOver();
        }
        //Uppdatera hälsa i GUI här
    }

    public static void changeEnemyBuildings(int change)
    {
        enemyBuildings += change;
        Debug.Log("Current buildings: " + enemyBuildings);
        if (enemyBuildings < 30 || enemyBuildings > 300)
        {
            gameOver();
        }
        //Uppdatera progressbar i GUI här
    }

    private static void gameOver()
    {
        if (enemyBuildings < 30)
        {
            //Victory screen
        } else
        {
            //Defeat screen
        }
    }
}
