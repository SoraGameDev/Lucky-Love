using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceButton : MonoBehaviour
{
    public GameObject diceObject;
    private Dice dice;

    private void Awake()
    {
        dice = diceObject.GetComponent<Dice>();
    }

    public void RollOnClick()
    {
        if (!dice.hasLanded)
        {
            dice.RollDice();
        }
        
    }
}
