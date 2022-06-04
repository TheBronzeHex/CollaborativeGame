using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Mover : MonoBehaviour
{
    Rigidbody Sphere;
    // Start is called before the first frame update
    void Start()
    {
        Sphere=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
            Sphere.AddForce(Vector3.forward*10,ForceMode.Force);
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Sphere.AddForce(Vector3.forward*-10,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            Sphere.AddForce(Vector3.up*30,ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale=transform.localScale+new Vector3(0.02f,0.02f,0.02f);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale=transform.localScale+new Vector3(-0.02f,-0.02f,-0.02f);
        }
    }
    private void OnCollisionEnter(Collision other) 
    {
        
            if (other.gameObject.CompareTag("Fruit")){

            
        Destroy(other.gameObject);
        }
    }
}
