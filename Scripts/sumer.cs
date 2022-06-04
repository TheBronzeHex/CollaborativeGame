using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int sum=combine(100);
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int combine(int n)
    {
        int sumer=0;
        for (int i = 0; i < n; i++)
        {
            sumer=sumer+i;
        }
        return sumer;
    }
}
