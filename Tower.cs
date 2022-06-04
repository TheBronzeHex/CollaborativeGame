using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {

         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit hitinfo;

         if(Physics.Raycast(ray, out hitinfo))
         {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = hitinfo.point + new Vector3(0, 0.5f, 0);
        cube.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        cube.AddComponent<Rigidbody>();

        }

        }
          
    }
    
}
