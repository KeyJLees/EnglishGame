using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingTrigger4 : MonoBehaviour
{
    public bool Text;
    public bool k;
    public Dialog dialog;
    public Animator animator;
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
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
    }
    void OnTriggerExit(Collider ot)
    {
        Text = false;
        animator.SetBool("bool4", true);
    }

    void OnGUI()
    {
        if (Text == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + 200, 80, 60), "Use E");
        }

    }
}
