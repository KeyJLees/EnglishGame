using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scream11 : MonoBehaviour
{
 
    public GameObject scream;
    private bool enter= false;
    private int time = 0;

    void Update()
    {
        if (enter == true)
        {
            time++;
            if (time > 100)
                Destroy(scream);
        }
    }
    void OnTriggerStay(Collider other)
    {



        scream.SetActive(true);
        enter = true;
            
        


    }

  
}
