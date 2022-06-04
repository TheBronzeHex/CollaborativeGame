using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size_Changer : MonoBehaviour
{
    public GameObject Cube;
    // Start is called before the first frame update
    void Start()
    {
        Create();
    }
    void Create()
    {
        for (int i = 0; i < 5; i++)
        {
            GameObject Clone=GameObject.Instantiate(Cube);
            Clone.transform.localScale=new Vector3(1,i,1);
            Clone.transform.position=new Vector3(i*2,(float)i/2,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
