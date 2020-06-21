using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dio : MonoBehaviour
{
    public GameObject Dio1;
    public GameObject Dio2;
    public Dialog dialog;
    public Animator animator;

    void Update()
    {
        if (animator.GetBool("bool1"))
        {
            Dio1.SetActive(false);
            Dio2.SetActive(true);
            FindObjectOfType<DialogManager2>().StartDialog2(dialog);
            animator.SetBool("bool1", false);
        }
    }

    public void updatebool()
    {
        animator.SetBool("bool1", true);
    }
}
