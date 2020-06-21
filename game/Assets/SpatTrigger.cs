using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpatTrigger : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public bool Text;
    public bool k;

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
            Player1.SetActive(false);
            Player2.SetActive(true);
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
