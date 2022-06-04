using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PointCollectionNav : MonoBehaviour
{
    NavMeshAgent PathFinder;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
     PathFinder = GetComponent<NavMeshAgent>();      
    }

    // Update is called once per frame
    void Update()
    {
     PathFinder.SetDestination(Player.transform.position);   
    }
   
}
