using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toiletscr : MonoBehaviour
{

    public GameObject toil;
    public GameObject scream;
    private bool op = false;
  
   

    void Update()
    {
        if(op == false)
            toil.GetComponent<Animator>().SetTrigger("close");
        if (op == true)
        {
            toil.GetComponent<Animator>().SetTrigger("open");
        }
    }
    void OnTriggerStay(Collider other)
    {

        op = true;
       
    }
}
