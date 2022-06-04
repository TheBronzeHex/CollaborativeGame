using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int result=returner(3,5);
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int returner(int one,int two)
    {
        return one*two;
    }
}
