using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.localScale=transform.localScale*1.5f;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.localScale=transform.localScale/1.5f;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody rgb = GetComponent<Rigidbody>();
            rgb.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }
    }
}
