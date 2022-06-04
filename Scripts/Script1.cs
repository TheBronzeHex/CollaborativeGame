using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int day=GetBirthdayInDays(2008);
        Debug.Log(day);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int GetBirthdayInDays(int BirthYear)
    {
        return (2021-BirthYear)*365;
    }
}
