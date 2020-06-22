using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireshow : MonoBehaviour
{
    public GameObject fire;
    public GameObject man;
    private bool check;
    public GameObject trigger;
    public GameObject text;


    void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<hasitemlast>().lighter == true && other.GetComponent<hasitemlast>().gas1 == true && other.GetComponent<hasitemlast>().gas2 == true && other.GetComponent<hasitemlast>().gas3 == true)
        {
            text.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F))
            {
                text.SetActive(false);
                fire.SetActive(true);
                man.SetActive(true);
                check = true;
                Destroy(man, 80);
                trigger.SetActive(false);
            }
        }


    }

}
