using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class lastded : MonoBehaviour
{
    public GameObject player;

    public float dist;
    NavMeshAgent nav;
    public float radius = 40;
  
    
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();

    }


    void Update()
    {
        dist = Vector3.Distance(player.transform.position, transform.position);
        if (dist > radius)
        {
            
            nav.enabled = false;
            gameObject.GetComponent<Animator>().SetTrigger("Idle");
        
            
        }
        if ((dist < radius) && (dist > 0))
        {
            nav.enabled = true;
            nav.SetDestination(player.transform.position);
            gameObject.GetComponent<Animator>().SetTrigger("Run");
        }
        if (dist <= 3)
            Destroy(gameObject);

    }



}
