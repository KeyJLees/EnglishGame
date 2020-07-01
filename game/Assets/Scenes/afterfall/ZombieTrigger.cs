using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Audio;
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Player3;
    public Animator animator;
    public Animator animatorD;
    public bool k = true;
    public Dialog dialog;
    void Update()
    {
        if (FindObjectOfType<DialogManager>().Finish() && FindObjectOfType<DialogManager>().Startt() && (animatorD.GetBool("isOne") == false))
        {
            Player2.SetActive(false);
            Player3.SetActive(true);
            animator.SetBool("uhod", true);
        }
    }
    void OnTriggerEnter(Collider ot)
    {
        Zombie.SetActive(true);
        Audio.SetActive(true);
        Player1.SetActive(false);
        Player2.SetActive(true);
        if (k)
        {
            k = false;
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
    }
}
