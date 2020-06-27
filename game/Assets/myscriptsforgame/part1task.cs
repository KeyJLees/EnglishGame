using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part1task : MonoBehaviour
{
    public bool Text1 = false;
 
  

    void OnGUI()
    {
        if (Text1 == true)
        {
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 400, 80, 60), "Идите за мужчиной(Доп:поговорить с жителями)", styleTime);
        }

       

    }
}
