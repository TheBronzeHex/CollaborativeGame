using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_A : MonoBehaviour
{
    public Script_B script;
    // Start is called before the first frame update
    void Start()
    {
        script.print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
