using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Counter(10);
    }
    void Counter (int n)
    {
        for (int i = 0; i < n; i++)
        {
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
