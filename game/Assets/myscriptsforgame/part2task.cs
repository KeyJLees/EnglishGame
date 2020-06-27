using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part2task : MonoBehaviour
{
    void OnGUI()
    {
      
            GUIStyle styleTime = new GUIStyle();
            styleTime.fontSize = 25;
            styleTime.normal.textColor = Color.yellow;
            GUI.Label(new Rect(Screen.width / 2 - 150, Screen.height / 2 - 400, 80, 60), "Найдите выход", styleTime);
        



    }
}
