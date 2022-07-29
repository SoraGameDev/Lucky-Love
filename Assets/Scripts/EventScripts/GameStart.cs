using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public Animator anim; 
    public int showScore;
    public int showGift, showLoc, showOpen, showCon, showEnd;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("gift"))
        {
            PlayerPrefs.SetInt("gift", 0);
        }
        if (!PlayerPrefs.HasKey("location"))
        {
            PlayerPrefs.SetInt("location", 0);
        }
        if (!PlayerPrefs.HasKey("opener"))
        {
            PlayerPrefs.SetInt("opener", 0);
        }
        if (!PlayerPrefs.HasKey("convo"))
        {
            PlayerPrefs.SetInt("convo", 0);
        }
        if (!PlayerPrefs.HasKey("closer"))
        {
            PlayerPrefs.SetInt("closer", 0);
        }

        PlayerPrefs.SetInt("Score", 0);

        PlayerPrefs.SetInt("location", 0);
        PlayerPrefs.SetInt("gift", 0);
        PlayerPrefs.SetInt("opener", 0);
        PlayerPrefs.SetInt("closer", 0);
        PlayerPrefs.SetInt("convo", 0);

        anim.SetTrigger("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        showScore = PlayerPrefs.GetInt("Score");
        showGift = PlayerPrefs.GetInt("gift");
        showLoc = PlayerPrefs.GetInt("location");
        showOpen = PlayerPrefs.GetInt("opener");
        showEnd = PlayerPrefs.GetInt("closer");
        showCon = PlayerPrefs.GetInt("convo");
    }
}
