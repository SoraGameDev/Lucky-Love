using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class IngameUI : MonoBehaviour
{
    public bool gamePaused;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gamePaused = !gamePaused;
        }

        if (gamePaused)
        {
            PauseGame();

            RuntimeManager.MuteAllEvents(true);
        }
        if (!gamePaused)
        {
            ResumeGame();
            RuntimeManager.MuteAllEvents(false);
        }

    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
}
