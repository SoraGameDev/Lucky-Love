using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suit : MonoBehaviour
{
    public bool gift, location, opener, convo, closer = false;
    public bool stopGift, stopLocation, stopOpener, stopConvo, stopCloser = false;


    // Start is called before the first frame update
    void Awake()
    {
        if (PlayerPrefs.GetInt("gift") > 0)
        {
            Debug.Log("Gift Check");
            GiftCheck();

        }
        if (PlayerPrefs.GetInt("location") > 0)
        {

            Debug.Log("Location Check");
            LocationCheck();


        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerPrefs.GetInt("opener") > 0 && stopOpener == false)
        {
            stopOpener = true;
            opener = true;
            
                Debug.Log("Location Check");
                OpenerCheck();
            
            
        }
        if (PlayerPrefs.GetInt("convo") > 0 && stopConvo == false)
        {
            stopConvo = true;
            convo = true;
            
                Debug.Log("Location Check");
                ConvoCheck();
            
            
        }
        if (PlayerPrefs.GetInt("closer") > 0 && stopCloser == false)
        {
            stopCloser = true;
            
            
                Debug.Log("Location Check");
                CloserCheck();
            
            
        }

        transform.position = GameObject.FindGameObjectWithTag("Date").transform.position;
        transform.rotation = GameObject.FindGameObjectWithTag("Date").transform.rotation;
    }

    void GiftCheck()
    {
        gift = false;
        if (PlayerPrefs.GetInt("gift") == 6)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("gift") == 4)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("gift") == 1)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
        }
    }

    void LocationCheck()
    {
        location = false;
        if (PlayerPrefs.GetInt("location") == 6)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("location") == 3)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("location") == 1)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
        }
    }

    void OpenerCheck()
    {
        opener = false;
        if (PlayerPrefs.GetInt("opener") == 5)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("opener") == 4)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("opener") == 3)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
        }
    }

    void ConvoCheck()
    {
        convo = false;
        if (PlayerPrefs.GetInt("convo") == 1)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("convo") == 5)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("convo") == 6)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
        }
    }

    void CloserCheck()
    {
        closer = false;
        if (PlayerPrefs.GetInt("closer") == 5)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("closer") == 3)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 1);
        }
        if (PlayerPrefs.GetInt("closer") == 2)
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 2);
        }
    }
}
