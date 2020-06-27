using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chek1 : MonoBehaviour
{
    public GameObject text;
    void OnTriggerStay(Collider other)
    {
        text.GetComponent<part1meeting>().dil = true;
        other.GetComponent<part1task>().Text1 = true;


    }
}
