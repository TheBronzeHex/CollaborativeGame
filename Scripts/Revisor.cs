using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revisor : MonoBehaviour
{
    int number;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 101; i++)
        {
            number=number+i;
        }
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
