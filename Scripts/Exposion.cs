using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exposion : MonoBehaviour
{
    public Sphere_Creator suhas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Explode()
    {
        GameObject.Destroy(gameObject);
        GameObject go= GameObject.Instantiate(suhas.prefab);
        go.transform.position=transform.position;
    }
}
