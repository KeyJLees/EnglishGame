using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    void OnTriggerEnter(Collider other)
    {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
    }

}
