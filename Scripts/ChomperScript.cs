using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChomperScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GoToRandom",2,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GoToRandom()
    {
        transform.position=new Vector3(Random.Range(-5,5),0,Random.Range(-5,5));
    }

  private void OnMouseDown() 
   {
       Destroy(gameObject);
   }
}
