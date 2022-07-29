using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using TMPro;
using UnityEngine.UI;
using FMODUnity;

public class Dice : MonoBehaviour
{
    public DiceSide[] diceSides;
    public int diceValue;
    public CinemachineVirtualCamera mainCam;
    Rigidbody rb;
    public Transform dicePos;
    public Transform datePos;
    public TextMeshProUGUI diceText;
    public GameObject textObject;
    public bool hasLanded;
    public bool isThrown;
    public int timesThrown;
    public GameObject giftEvent, locationEvent, openerEvent, convoEvent, closerEvent;
    public GameObject giftText, locationText, openerText, convoText, closerText;
    public GameObject diceButton;
    [SerializeField] EventReference diceThrow;
    public bool giftEnd, locationEnd, openEnd, convoEnd, closerEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        //textObject.SetActive(false);
        timesThrown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.IsSleeping() && !hasLanded && isThrown)
        {
            hasLanded = true;
            rb.useGravity = false;
            rb.isKinematic = true;

            CheckValue();
           // textObject.SetActive(true);
            diceText.text = diceValue.ToString();
            mainCam.m_LookAt = datePos;
            timesThrown++;
        }

        if(timesThrown == 0)
        {
            giftText.SetActive(true);
        }
        if(timesThrown == 1)
        {
            if(giftEnd == false)
            {
                StartGift();
            }
            
            giftText.SetActive(false);

        }
        if(timesThrown == 2)
        {
            if(locationEnd == false)
            {
                StartLocation();
            }

            locationText.SetActive(false);
            
        }
        if(timesThrown == 3)
        {
            if(openEnd == false)
            {
                StartOpener();
            }

            openerText.SetActive(false);
           // openerEvent.SetActive(true);
        }
        if(timesThrown == 4)
        {
            if(convoEnd == false)
            {
                StartConvo();
            }

            convoText.SetActive(false);
           // convoEvent.SetActive(true);
        }
        if(timesThrown == 5)
        {
            if(closerEnd == false)
            {
                StartCloser();
            }

            closerText.SetActive(false);
           // closerEvent.SetActive(true);
        }
        
    }

    public void RollDice()
    {
        isThrown = true;
        rb.useGravity = true;
        rb.AddTorque(Random.Range(200, 300), Random.Range(200, 300), Random.Range(200, 300));
        rb.AddForce(transform.up * Random.Range(400,500));
        rb.AddForce(transform.forward * 100);
        diceButton.SetActive(false);
        mainCam.m_LookAt = dicePos;
        RuntimeManager.PlayOneShot(diceThrow);
    }

    void StartGift()
    {
        giftEnd = true;
        giftEvent.SetActive(true);
    }
    void StartLocation()
    {
        locationEnd = true;
        locationEvent.SetActive(true);
    }
    void StartOpener()
    {
        openEnd = true;
        openerEvent.SetActive(true);
    }
    void StartConvo()
    {
        convoEnd = true;
        convoEvent.SetActive(true);
    }
    void StartCloser()
    {
        closerEnd = true;
        closerEvent.SetActive(true);
    }


    void CheckValue()
    {
        diceValue = 0;
        foreach(DiceSide side in diceSides)
        {
            if (side.IsGrounded())
            {
                diceValue = side.sideValue;
                Debug.Log(diceValue);
            }
        }


    }

    public void ResetDice()
    {
        isThrown = false;
        hasLanded = false;
        diceButton.SetActive(true);
        rb.useGravity = false;
        rb.isKinematic = false;
        diceValue = 0;
        
    }
}
