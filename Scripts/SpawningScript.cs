using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningScript : MonoBehaviour
{
public GameObject Thing1;
public GameObject Thing2;
public GameObject Thing3;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnThings",0,3);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
void SpawnThings()
{
GameObject Clone1=GameObject.Instantiate(Thing1);
Clone1.transform.position=new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
GameObject Clone2=GameObject.Instantiate(Thing2);
Clone2.transform.position=new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));
GameObject Clone3=GameObject.Instantiate(Thing3);
Clone3.transform.position=new Vector3(Random.Range(-10,10),0,Random.Range(-10,10));

}


}
