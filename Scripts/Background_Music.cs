using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound_Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        player();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void player ()
    {
        GetComponent<AudioSource>().Play();
    }
}


