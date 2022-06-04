using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dddddddddddddddddddddddddddd : MonoBehaviour
{
public GameObject ObjectToExplode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
{
 explode(3);
}
    }
   void explode(int x)
{
GameObject Clone=GameObject.Instantiate(ObjectToExplode);
Clone.transform.position=Clone.transform.position+new Vector3(Random.Range(0,10),0,Random.Range(0,10));
gameObject.GetComponent<AudioSource>().Play();
}

}
