using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenerEvent : MonoBehaviour
{
    public int openerValue;
    public GameObject suit, adventurer, medieval, punk, witch, soldier;
    public Dice dice;
    public bool openerDone = false;
    public GameObject conversationText;
    public GameObject dicePos, desertPos, barPos, templePos, coffeePos, wizardPos, dungeonPos;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("opener", 0);
    }

    // Update is called once per frame
    void Update()
    {
        openerValue = dice.diceValue;

        if(openerValue == 1)
        {
            PlayerPrefs.SetInt("opener", 1);

            soldier.SetActive(true);
        }
        if (openerValue == 2)
        {
            PlayerPrefs.SetInt("opener", 2);

            witch.SetActive(true);
        }
        if (openerValue == 3)
        {
            PlayerPrefs.SetInt("opener", 3);

            suit.SetActive(true);
        }
        if (openerValue == 4)
        {
            PlayerPrefs.SetInt("opener", 4);

            punk.SetActive(true);
        }
        if (openerValue == 5)
        {
            PlayerPrefs.SetInt("opener", 5);

            adventurer.SetActive(true);
        }
        if (openerValue == 6)
        {
            PlayerPrefs.SetInt("opener", 6);

            medieval.SetActive(true);
        }

        if (openerDone == true)
        {
            GoToNext();
        }
    }

    void GoToNext()
    {
        conversationText.SetActive(true);
        dice.ResetDice();
        Destroy(gameObject);

        if(PlayerPrefs.GetInt("location") == 1)
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
