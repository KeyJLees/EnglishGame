using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takegas1 : MonoBehaviour
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
            other.GetComponent<hasitemlast>().gas1 = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        text.SetActive(false);
    }
}
