using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateSpawner : MonoBehaviour
{
    public GameObject[] dates;

    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(dates[Random.Range(0, dates.Length)], transform.position, transform.rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
