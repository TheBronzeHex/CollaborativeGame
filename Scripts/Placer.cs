using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placer : MonoBehaviour
{ GameObject [] Array=new GameObject[10];
    
    // Start is called before the first frame update
     void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Array[i]=GameObject.CreatePrimitive(PrimitiveType.Capsule);
            Array[i].transform.position=new Vector3(i*2,1,1);
        }
        InvokeRepeating("AdvanceArmy",0,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void AdvanceArmy()
    {
        for (int i = 0; i < 10; i++)
        {
            Array[i].transform.position=Array[i].transform.position+new Vector3(0,0,Random.Range(0,0.5f));
        }
    }

}
