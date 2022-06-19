using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollision : MonoBehaviour
{
    public GameObject Points;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider other)
    {
     if (other.gameObject.name != "Plane" && other.gameObject.name != "Polyart_Golem")
     {
     GameObject.Destroy(other.gameObject);
     points = points + 1;
     Debug.Log ("You've got " + points + " points");
     }
     
     if (other.gameObject.name == "Polyart_Golem")
    {


    }
    }
}
