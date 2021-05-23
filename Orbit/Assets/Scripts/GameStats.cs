using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour
{
    [SerializeField] private int playerHealth = 5;
    private static int enemyBuildings = 0;
    public Player_UI player_UI;
    private bool gameStarted = false;
    public int winCondition = 198;

    public void Start()
    {
        player_UI.setStartHealth(playerHealth);
        player_UI.setWinConditionBuildings(winCondition);
    }
    public void changeHealth(int change)
    {
        playerHealth += change;
        Debug.Log("Player health: " + playerHealth);
        if (playerHealth < 1)
        {
            gameOver();
        }
        //Update UI
        player_UI.setCurrentHealth(playerHealth);
    }

    public void changeEnemyBuildings(int change)
    {
        enemyBuildings += change;
        Debug.Log("Current buildings: " + enemyBuildings);
        if (gameStarted && (enemyBuildings < winCondition))
        {
            gameOver();
        }
        //Update UI
        player_UI.setCurrentBuildings(enemyBuildings);
    }

    public void gameOver()
    {
        if (enemyBuildings < winCondition)
        {
            //Victory screen
            player_UI.Win();
        } else
        {
            player_UI.Dead();
            //Defeat screen
        }
    }

    public void startGame()
    {
        gameStarted = true;
    }
}
