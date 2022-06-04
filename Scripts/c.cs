using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c : MonoBehaviour
{
 int Value;
    // Start is called before the first frame update
    void Start()
    {
        GetSum(12);
       Debug.Log(Value);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int GetSum(int n)
{ 
 for(int i = 0; i < n; i++)
{
  Value=Value+i;
}
return Value;

}

}
