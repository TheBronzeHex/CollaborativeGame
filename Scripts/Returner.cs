using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Returner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int result=giver();
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int giver()
    {
        return 5;
    }
    Vector3 returnavector()
    {
        return new Vector3(1,1,1);
    }
    GameObject returnago()
    {
        return GameObject.CreatePrimitive(PrimitiveType.Sphere);
    }
}
