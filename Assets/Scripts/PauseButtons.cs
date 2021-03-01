using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButtons : MonoBehaviour
{
    public static bool scenePause = false;
    public GameObject pauseMenu;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (scenePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void  Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        scenePause = false;
    }
    void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        scenePause = true;
    }
    public void returnToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        scenePause = false;
    }
    
}
