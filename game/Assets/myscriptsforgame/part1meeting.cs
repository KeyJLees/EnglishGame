using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class part1meeting : MonoBehaviour
{
    private GameObject point;
    public string tag_point;
    NavMeshAgent nav;

    void Update()
    {
        gameObject.GetComponent<Animator>().SetBool("Walk", true);
        point = GameObject.FindGameObjectWithTag(tag_point);
        nav = GetComponent<NavMeshAgent>();
        nav.enabled = true;
        nav.SetDestination(point.transform.position);

    }

    
}
