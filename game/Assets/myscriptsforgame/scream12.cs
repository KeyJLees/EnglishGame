using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scream12 : MonoBehaviour
{
    public GameObject scream;
    public GameObject trigger;
    private int time = 0;
    private bool enter = false;

    void Update()
    {
        if (enter == true)
        {
            time++;
            if (time > 100)
            {
                scream.SetActive(false);
                trigger.SetActive(false);
            }
        }

    }
    void OnTriggerStay(Collider other)
    {
        if ((other.GetComponent<hasitemlast>().gas1 == true) && (other.GetComponent<hasitemlast>().lighter == true))
        {
            scream.SetActive(true);
            enter = true;
        }

    }
}
