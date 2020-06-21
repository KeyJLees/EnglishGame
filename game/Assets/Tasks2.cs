using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tasks2 : MonoBehaviour
{
    public bool Text1 = false;
    public bool Text2 = true;
    private bool ty = true;
    public Dialog dialog;
    public Animator animator;

    void Update()
    {
        if (animator.GetBool("bool0") == true && animator.GetBool("bool1") == true && animator.GetBool("bool2") == true && animator.GetBool("bool3") == true && animator.GetBool("bool4") == true && ty == true)
        {
            Text1 = true;
            Text2 = false;
            FindObjectOfType<DialogManager>().StartDialog(dialog);
            ty = false;
        }
    }


    void OnGUI()
    {
        if (Text1 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 10, Screen.height / 2 - 400, 80, 60), "Уходите", styleTime);
        }

        if (Text2 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 170, Screen.height / 2 - 400, 80, 60), "Узнайте, что произошло с вашими родителями", styleTime);
        }


    }
}
