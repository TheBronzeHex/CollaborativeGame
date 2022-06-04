using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareInASqaure : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <30; i=i+3)
        {
            CloneSquares(i);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CloneSquares(int size)
    {
        for (int i = 0; i <size ; i++)
        {
            GameObject Clone=GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Clone.transform.position=new Vector3(i,0,0);

        }
        for (int i = 0; i < size; i++)
        {
            GameObject Clone=GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Clone.transform.position=new Vector3(0,i,0);

        }
        for (int i = 0; i < size; i++)
        {
            GameObject Clone=GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Clone.transform.position=new Vector3(i,size,0);

        }
        for (int i = 0; i < size; i++)
        {
            GameObject Clone=GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Clone.transform.position=new Vector3(size,i,0);

        }
        
       
    }
}
