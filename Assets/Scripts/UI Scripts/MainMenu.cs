using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using FMODUnity;

public class MainMenu : MonoBehaviour
{
    public GameObject launchText;
    public GameObject SettingsMenu;

    [SerializeField] EventReference clickOn, clickOff;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("FirstLaunch"))
        {
            PlayerPrefs.SetInt("FirstLaunch", 0);
        }
        if (PlayerPrefs.GetInt("FirstLaunch") == 0)
        {
            launchText.SetActive(true);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseLaunchText()
    {
        launchText.SetActive(false);
        PlayerPrefs.SetInt("FirstLaunch", 1);
        RuntimeManager.PlayOneShot(clickOff);
    }

    public void OpenTwitter()
    {
        Application.OpenURL("https://twitter.com/SoraGameDev");
        RuntimeManager.PlayOneShot(clickOn);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        RuntimeManager.PlayOneShot(clickOn);
    }

    public void CloseGame()
    {
        Application.Quit();
        RuntimeManager.PlayOneShot(clickOn);
    }

    public void OpenSettingsMenu()
    {
        SettingsMenu.SetActive(true);
        RuntimeManager.PlayOneShot(clickOn);
    }

    public void CloseSettingsMenu()
    {
        SettingsMenu.SetActive(false);
        RuntimeManager.PlayOneShot(clickOff);
    }
}
