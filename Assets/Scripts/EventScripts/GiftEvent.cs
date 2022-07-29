using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;

public class GiftEvent : MonoBehaviour
{
    public int giftValue;
    public GameObject rose, chest, tank, potion, sword, guitar;
    public Dice dice;
    public GameObject player;
    public GameObject cameraLookAt;
    public GameObject diceObject;
    public GameObject nextPlayerPos;
    public GameObject nextCamPos;
    public GameObject nextDicePos;
    public Animator screenFade;
    public GameObject locationText;
    [SerializeField] EventReference giftGet;
    public bool playSound = false;


    // Start is called before the first frame update
    void Start()
    {
        playSound = false;
        PlayerPrefs.SetInt("gift", 0);
    }

    // Update is called once per frame
    void Update()
    {
        giftValue = dice.diceValue;

        if(giftValue == 1)
        {
            rose.SetActive(true);
            PlayerPrefs.SetInt("gift", 1);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if(playSound == false)
            {
                PlaySound();
            }
        }
        if (giftValue == 2)
        {
            potion.SetActive(true);
            PlayerPrefs.SetInt("gift", 2);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if (playSound == false)
            {
                PlaySound();
            }
        }
        if (giftValue == 3)
        {
            sword.SetActive(true);
            PlayerPrefs.SetInt("gift", 3);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if (playSound == false)
            {
                PlaySound();
            }
        }
        if (giftValue == 4)
        {
            guitar.SetActive(true);
            PlayerPrefs.SetInt("gift", 4);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if (playSound == false)
            {
                PlaySound();
            }
        }
        if (giftValue == 5)
        {
            tank.SetActive(true);
            PlayerPrefs.SetInt("gift", 5);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if (playSound == false)
            {
                PlaySound();
            }
        }
        if (giftValue == 6)
        {
            chest.SetActive(true);
            PlayerPrefs.SetInt("gift", 6);
            Invoke(nameof(ScreenWipe), 5f);
            Invoke(nameof(MoveToNext), 5f);
            if (playSound == false)
            {
                PlaySound();
            }
        }

    }


    void MoveToNext()
    {
        player.transform.SetPositionAndRotation(nextPlayerPos.transform.position, Quaternion.identity);
        cameraLookAt.transform.SetPositionAndRotation(nextCamPos.transform.position, Quaternion.identity);
        diceObject.transform.SetPositionAndRotation(nextDicePos.transform.position, nextDicePos.transform.localRotation);
        dice.ResetDice();
        Destroy(gameObject);
        locationText.SetActive(true);
    }
    void PlaySound()
    {
        playSound = true;
        RuntimeManager.PlayOneShot(giftGet);
    }

    void ScreenWipe()
    {
        screenFade.SetTrigger("ScreenFade");
    }
}
