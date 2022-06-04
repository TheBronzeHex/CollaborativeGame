using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Maker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Spheres();
        float Decimal=15.4f;
        int Number=5;
    }
    void Spheres()
    {
        for (int i = 0; i < 101; i++)
        {
            GameObject Clones = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Clones.AddComponent<Rigidbody>();
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
