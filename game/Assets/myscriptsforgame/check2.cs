using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class check2 : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
    
        if (Input.GetKeyDown(KeyCode.F))
        {
            
           if(other.GetComponent<hasitem>().goldkey == true && other.GetComponent<hasitem>().silverkey==true)
                SceneManager.LoadScene("afterhouse");
        }


    }
}
