using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public bool Text;
    public bool k;
    public Animator animator;
    public GameObject Audio;
    void OnTriggerEnter(Collider ot)
    {
        if (animator.GetBool("get"))
        {
            Text = true;
            k = true;
        }
    }
    void OnTriggerStay(Collider ot)
    {
        if (Input.GetKeyDown(KeyCode.E) && k && animator.GetBool("get"))
        {
            Text = false;
            k = false;
            Audio.SetActive(true);
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
