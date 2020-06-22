using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takelighter : MonoBehaviour
{
    public GameObject text;
    public GameObject trigger;
    void OnTriggerStay(Collider other)
    {
        text.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F))
        {

            trigger.SetActive(false);
            text.SetActive(false);
            other.GetComponent<hasitemlast>().lighter = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
