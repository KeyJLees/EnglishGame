﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeTrigger : MonoBehaviour
{
    public bool Text;
    public bool k;
    public Animator animator;
    public GameObject Axe;
    void OnTriggerEnter(Collider ot)
    {
        Text = true;
        k = true;
    }
    void OnTriggerStay(Collider ot)
    {
        if (Input.GetKeyDown(KeyCode.E) && k)
        {
            Text = false;
            k = false;
            animator.SetBool("get", true);
        }
    }
    void OnTriggerExit(Collider ot)
    {
        Text = false;
    }

    void OnGUI()
    {
        if (Text == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + 200, 80, 60), "Use E");
        }

    }
}
