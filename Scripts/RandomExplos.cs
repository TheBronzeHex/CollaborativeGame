using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomExplos : MonoBehaviour
{
    GameObject Explode;
    AudioSource boom;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            explosion(6);
        }
    }
    void explosion(int x=1)
    {  
        GameObject.Instantiate(Explode);
        boom.Play();
        Explode.transform.position=new Vector3 (Random.Range(0,5),1,Random.Range(0,5));
    }
}
