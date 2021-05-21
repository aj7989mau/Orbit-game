using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBarScript healthbar;

    public GameObject deadUI;
    public GameObject winUI;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
        winUI.SetActive(false);
        deadUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

        if (currentHealth <= 0)
        {
            Dead();
        }

        if (Input.GetKeyDown(KeyCode.P)) //Place holder to see if the win scene works
        {
            Win();
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthbar.SetHealth(currentHealth);
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
        SceneManager.LoadScene("GUI");
    }

}
