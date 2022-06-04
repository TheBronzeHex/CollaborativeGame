using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : MonoBehaviour
{
    bool isGameRunning=true;
    // Start is called before the first frame update

    int colorId;
    void Start()
    {
        InvokeRepeating("ChangeColor",0,1f);
    }
    

    // Update is called once per frame
    void Update()
    
    {
        if(isGameRunning==true)
        {
            if(Input.GetKeyDown(KeyCode.Space))
        {
            if(colorId == 3)
            {
                isGameRunning=false;
                Invoke("UnPauseGame",2);
                AudioSource ads=GetComponent<AudioSource>();
                ads.Play();
            }
        }
        

        }
    }
    void ChangeColor()
    {
         MeshRenderer renderer = GetComponent <MeshRenderer>();
       
        colorId = Random.Range(1, 10);
        if(colorId == 1)
        {
                 renderer.material.color = Color.blue;
        }
        else if( colorId == 2)
        {
            renderer.material.color = Color.red;
        }
        else if( colorId == 3)
        {
            renderer.material.color = Color.green;
        }
        else if( colorId == 4)
        {
            renderer.material.color = Color.yellow;
        }
        else if( colorId == 5)
        {
            renderer.material.color = Color.black;
        }
        else if( colorId == 6)
        {
            renderer.material.color = Color.magenta;
        }
        else if( colorId == 7)
        {
            renderer.material.color = Color.cyan;
        }
        else if( colorId == 8)
        {
            renderer.material.color = Color.clear;
        }
        else if( colorId == 9)
        {
            renderer.material.color = Color.gray;
        }
        else if( colorId == 10)
        {
            renderer.material.color = Color.white;
        }

    }
    void UnPauseGame()
              {
                isGameRunning=true;
              }
}
