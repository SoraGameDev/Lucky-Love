using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationEvent : MonoBehaviour
{
    public int convoValue;
    public GameObject suit, adventurer, medieval, punk, witch, soldier;
    public Dice dice;
    public GameObject dicePos, desertPos, barPos, templePos, coffeePos, wizardPos, dungeonPos;
    public bool convoEnded = false;
    public GameObject closerText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("convo", 0);   
    }

    // Update is called once per frame
    void Update()
    {
        convoValue = dice.diceValue;

        if(convoValue == 1)
        {
            PlayerPrefs.SetInt("convo", 1);

            adventurer.SetActive(true);

        }
        if (convoValue == 2)
        {
            PlayerPrefs.SetInt("convo", 2);

            medieval.SetActive(true);
        }
        if (convoValue == 3)
        {
            PlayerPrefs.SetInt("convo", 3);

            soldier.SetActive(true);
        }
        if (convoValue == 4)
        {
            PlayerPrefs.SetInt("convo", 4);
            witch.SetActive(true);
        }
        if (convoValue == 5)
        {
            PlayerPrefs.SetInt("convo", 5);
            punk.SetActive(true);
        }
        if (convoValue == 6)
        {
            PlayerPrefs.SetInt("convo", 6);

            suit.SetActive(true);
        }

        if(convoEnded == true)
        {
            GoToNext();
        }

    }

    void GoToNext()
    {
        closerText.SetActive(true);
        dice.ResetDice();
        Destroy(gameObject);

        if (PlayerPrefs.GetInt("location") == 1)
        {
            dicePos.transform.SetPositionAndRotation(coffeePos.transform.position, coffeePos.transform.localRotation);
        }
        if (PlayerPrefs.GetInt("location") == 2)
        {
            dicePos.transform.SetPositionAndRotation(desertPos.transform.position, desertPos.transform.localRotation);
        }
        if (PlayerPrefs.GetInt("location") == 3)
        {
            dicePos.transform.SetPositionAndRotation(barPos.transform.position, barPos.transform.localRotation);
        }
        if (PlayerPrefs.GetInt("location") == 4)
        {
            dicePos.transform.SetPositionAndRotation(dungeonPos.transform.position, dungeonPos.transform.localRotation);
        }
        if (PlayerPrefs.GetInt("location") == 5)
        {
            dicePos.transform.SetPositionAndRotation(wizardPos.transform.position, wizardPos.transform.localRotation);
        }
        if (PlayerPrefs.GetInt("location") == 6)
        {
            dicePos.transform.SetPositionAndRotation(templePos.transform.position, templePos.transform.localRotation);
        }
    }
}
