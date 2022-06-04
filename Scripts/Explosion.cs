using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{  public CreateScript script;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 
     public void Explode()
{
GameObject.Destroy(gameObject);
 GameObject CloneThing=GameObject.Instantiate(script.Prefab);
CloneThing.transform.position=transform.position;

script.PlayAudio();
}

}
