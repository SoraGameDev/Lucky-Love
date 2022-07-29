using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using FMODUnity;

public class GameEnd : MonoBehaviour
{
    public GameObject badText, goodText, greatText;
    public TextMeshProUGUI score;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = PlayerPrefs.GetInt("Score").ToString();
        
        if (PlayerPrefs.GetInt("Score") < 5)
        {
            badText.SetActive(true);
            goodText.SetActive(false);
            greatText.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Score") >= 5 && (PlayerPrefs.GetInt("Score") < 10))
        {
            badText.SetActive(false);
            goodText.SetActive(true);
            greatText.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Score") >= 10)
        {
            badText.SetActive(false);
            goodText.SetActive(false);
            greatText.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        RuntimeManager.MuteAllEvents(false);
    }
}
