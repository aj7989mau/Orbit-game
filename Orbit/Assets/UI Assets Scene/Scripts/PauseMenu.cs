using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject InstructionsMenuUI;

    int k = 0;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && k == 0)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (GameIsPaused)
            {
                LoadMenu();
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            k = 1;

            if (GameIsPaused)
            {
                LoadInstructions();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (GameIsPaused)
            {
                QuitGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            k = 0;
            if (GameIsPaused)
            {
                Back();
            }
        }

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("Level_1");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void LoadInstructions()
    {
        pauseMenuUI.SetActive(false);
        InstructionsMenuUI.SetActive(true);
    }

    public void Back()
    {
        pauseMenuUI.SetActive(true);
        InstructionsMenuUI.SetActive(false);
    }
}
