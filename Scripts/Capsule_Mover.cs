using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Capsule_Mover : MonoBehaviour
{
    NavMeshAgent PathFinder;
    // Start is called before the first frame update
    void Start()
    {
     PathFinder = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown(0))
     {

       Ray Ray1 = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hitInfo;
       if (Physics.Raycast(Ray1,out hitInfo))
       {

       PathFinder.SetDestination(hitInfo.point);

       } 
     }
    }
}
