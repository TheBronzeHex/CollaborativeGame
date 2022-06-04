using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Creator : MonoBehaviour
{
    GameObject[] sphere = new GameObject[1000];
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= 1000; i++)
        {
            GameObject go=GameObject.CreatePrimitive(PrimitiveType.Sphere);
            go.transform.position=new Vector3(Random.Range(-50,50),0.5f,Random.Range(-50,50));
            go.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            sphere[i] = go;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void RandomExplode()
    {
        int random=Random.Range(0,1000);
        Exposion explosive=sphere[random].GetComponent<Exposion>();
        explosive.Explode();
    }
}
