using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling_MOvement_Script : MonoBehaviour
{
    
   public GameObject watermelon;

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("spawner",2,20);
    }
    void spawner()
    {
        GameObject clone=GameObject.Instantiate(watermelon);
        clone.transform.position=new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
        clone.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
