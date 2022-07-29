using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloserEvent : MonoBehaviour
{
    public int closerValue;
    public GameObject suit, adventurer, medieval, punk, witch, soldier;
    public Dice dice;
    public bool closerEnded = false;
    public Animator anim;
    public GameObject gameEnd;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("closer", 0);
    }

    void Update()
    {
        closerValue = dice.diceValue;

        if (closerValue == 1)
        {
            PlayerPrefs.SetInt("closer", 1);

            soldier.SetActive(true);

        }
        if (closerValue == 2)
        {
            PlayerPrefs.SetInt("closer", 2);

            suit.SetActive(true);
        }
        if (closerValue == 3)
        {
            PlayerPrefs.SetInt("closer", 3);

            punk.SetActive(true);
        }
        if (closerValue == 4)
        {
            PlayerPrefs.SetInt("closer", 4);
            medieval.SetActive(true);
        }
        if (closerValue == 5)
        {
            PlayerPrefs.SetInt("closer", 5);
            adventurer.SetActive(true);
        }
        if (closerValue == 6)
        {
            PlayerPrefs.SetInt("closer", 6);

            witch.SetActive(true);
        }

        if (closerEnded == true)
        {
            anim.SetTrigger("FadeOut");

            Invoke(nameof(GoToNext), 1.2f);
        }



    }

    void GoToNext()
    {
        gameEnd.SetActive(true);
        Destroy(gameObject);
    }
}
