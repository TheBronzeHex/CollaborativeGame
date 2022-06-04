using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateScript : MonoBehaviour
{  public GameObject Prefab;
 AudioSource Sound;
GameObject[] Sphere = new GameObject[1000];

    // Start is called before the first frame update
    void Start()
    {
   Sound=GetComponent<AudioSource>();
       for(int i = 0; i <= 999; i++)
     {
      GameObject Spheres=GameObject.CreatePrimitive(PrimitiveType.Sphere);
Spheres.AddComponent<Explosion>();
Spheres.GetComponent<Explosion>().script=this;

     Spheres.transform.position= new Vector3(Random.Range(-50,50),0,Random.Range(-50,50));
      Spheres.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
       Sphere[i] = Spheres;
     }
InvokeRepeating("ExplodeRandom",0,0.5f);
 
    }

    // Update is called once per frame
    void Update()
    {
        

    }

  void ExplodeRandom()
{
 int RandomNumber=Random.Range(1,1000);
GameObject RandomSphere=Sphere[RandomNumber];
RandomSphere.GetComponent<Explosion>().Explode();
}
public void PlayAudio()
{
Sound.Play();
}

}
