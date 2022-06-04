using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper : MonoBehaviour
{
    int RotationSpeed=100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, RotationSpeed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.RightArrow))
        RotationSpeed=RotationSpeed+100;

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        RotationSpeed=RotationSpeed-100;

    }
}
