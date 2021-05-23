using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_UI : MonoBehaviour
{
    public HealthBarScript healthbar;

    public GameObject deadUI;
    public GameObject winUI;

    void Start()
    {

        winUI.SetActive(false);
        deadUI.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Restart();
        }
    }

    public void setCurrentBuildings(int enemyBuildings)
    {

    }

        public void setStartHealth(int startHealth)
    {
        healthbar.SetMaxHealth(startHealth);
    }

    public void setCurrentHealth(int health)
    {
        healthbar.SetHealth(health);
    }

    public void Dead()
    {
        deadUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void Win()
    {
        winUI.SetActive(true);
        Time.timeScale = 0;
        //If the player reaches the goal, you win
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level_1");
    }


}
