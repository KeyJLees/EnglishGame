using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffTrigger : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public bool Text;
    public bool k;
    public Animator animator;

    void OnTriggerEnter(Collider ot)
    {
        if (animator.GetBool("bool0") == true && animator.GetBool("bool1") == true && animator.GetBool("bool2") == true && animator.GetBool("bool3") == true && animator.GetBool("bool4") == true)
        {
            Text = true;
            k = true;
        }
    }
    void OnTriggerStay(Collider ot)
    {
        if (animator.GetBool("bool0") == true && animator.GetBool("bool1") == true && animator.GetBool("bool2") == true && animator.GetBool("bool3") == true && animator.GetBool("bool4") == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && k)
            {
                Text = false;
                k = false;
                Player1.SetActive(false);
                Player2.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider ot)
    {
        if (animator.GetBool("bool0") == true && animator.GetBool("bool1") == true && animator.GetBool("bool2") == true && animator.GetBool("bool3") == true && animator.GetBool("bool4") == true)
        {
            Text = false;
        }
    }

    void OnGUI()
    {
        if (Text == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2 + 200, 80, 60), "Use E");
        }

    }
}
