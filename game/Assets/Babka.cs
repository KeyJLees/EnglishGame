using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babka : MonoBehaviour
{
    public bool k = true;
    public Dialog dialog;
    public Animator animator1;
    public Animator animator2;

    void OnTriggerStay(Collider ot)
    {
        if (k)
        {
            k = false;
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
        if (Input.GetKeyDown(KeyCode.F) && k == false)
        {
            animator1.SetBool("bool", true);
            animator2.SetBool("boolb", true);
        }
    }

}
