using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarmUP : MonoBehaviour
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
       Vector3 Place = HitPoint();
       Debug.Log(Place);
       GameObject Spawningerthing = GameObject.CreatePrimitive(PrimitiveType.Cube);
       Spawningerthing.transform.position = Place + new Vector3 (0,0.5f,0);
       Spawningerthing.AddComponent<Rigidbody>();
       Spawningerthing.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }

    Vector3 HitPoint() 
    {
     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     RaycastHit Hitinfo;
     if(Physics.Raycast(ray, out Hitinfo))
     {
      Vector3 Hitpoint = Hitinfo.point;
      return Hitpoint;
     }
     return new Vector3 (-5,1,6);

     }
}}
