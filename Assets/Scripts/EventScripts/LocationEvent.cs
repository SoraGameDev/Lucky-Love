using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
public class LocationEvent : MonoBehaviour
{
    public int locationValue;
    public GameObject player, cam, diceObject;
    public GameObject barPlayer, barCam, barDice;
    public GameObject desertPlayer, desertCam, desertDice;
    public GameObject dungeonPlayer, dungeonCam, dungeonDice;
    public GameObject wizardPlayer, wizardCam, wizardDice;
    public GameObject coffeePlayer, coffeeCam, coffeeDice;
    public GameObject templePlayer, templeCam, templeDice;
    public Dice dice;
    public GameObject bar, desert, dungeon, wizard, coffee, temple;
    public Animator anim;
    public GameObject openerText;

    public GameObject datespawn;

    [SerializeField] EventReference locationGet;
    bool playSound;


    // Start is called before the first frame update
    void Start()
    {
        playSound = false;
        PlayerPrefs.SetInt("location", 0);
        //dates = new GameObject[];
    }

    // Update is called once per frame
    void Update()
    {
        locationValue = dice.diceValue;

        if(locationValue == 1)
        {
            coffee.SetActive(true);
            PlayerPrefs.SetInt("location", 1);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToCoffee), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
        if (locationValue == 2)
        {
            desert.SetActive(true);
            PlayerPrefs.SetInt("location", 2);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToDesert), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
        if (locationValue == 3)
        {
            bar.SetActive(true);
            PlayerPrefs.SetInt("location", 3);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToBar), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
        if (locationValue == 4)
        {
            dungeon.SetActive(true);
            PlayerPrefs.SetInt("location", 4);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToDungeon), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
        if (locationValue == 5)
        {
            wizard.SetActive(true);
            PlayerPrefs.SetInt("location", 5);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToWizard), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
        if (locationValue == 6)
        {
            temple.SetActive(true);
            PlayerPrefs.SetInt("location", 6);
            Invoke(nameof(ScreenFade), 5f);
            Invoke(nameof(MoveToTemple), 5f);
            if (playSound == false)
            {
                PlaySound();
            }

        }
    }
    
    void PlaySound()
    {
        playSound = true;
        RuntimeManager.PlayOneShot(locationGet);
    }

    void MoveToBar()
    {
        player.transform.SetPositionAndRotation(barPlayer.transform.position, barPlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(barCam.transform.position, barCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(barDice.transform.position, barDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void MoveToTemple()
    {
        player.transform.SetPositionAndRotation(templePlayer.transform.position, templePlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(templeCam.transform.position, templeCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(templeDice.transform.position, templeDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void MoveToDesert()
    {
        player.transform.SetPositionAndRotation(desertPlayer.transform.position, desertPlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(desertCam.transform.position, desertCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(desertDice.transform.position, desertDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void MoveToCoffee()
    {
        player.transform.SetPositionAndRotation(coffeePlayer.transform.position, coffeePlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(coffeeCam.transform.position, coffeeCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(coffeeDice.transform.position, coffeeDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void MoveToDungeon()
    {
        player.transform.SetPositionAndRotation(dungeonPlayer.transform.position, dungeonPlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(dungeonCam.transform.position, dungeonCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(dungeonDice.transform.position, dungeonDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void MoveToWizard()
    {
        player.transform.SetPositionAndRotation(wizardPlayer.transform.position, wizardPlayer.transform.localRotation);
        cam.transform.SetPositionAndRotation(wizardCam.transform.position, wizardCam.transform.localRotation);
        diceObject.transform.SetPositionAndRotation(wizardDice.transform.position, wizardDice.transform.localRotation);
        Destroy(gameObject);
        dice.ResetDice();
    }
    void ScreenFade()
    {
        datespawn.SetActive(true);
        anim.SetTrigger("ScreenFade");
        openerText.SetActive(true);
    }
}
