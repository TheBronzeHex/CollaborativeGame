using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
  public ScriptB script;
    // Start is called before the first frame update
    void Start()
    {
        script.Print();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
