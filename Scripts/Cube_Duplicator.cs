using UnityEngine;

public class Cube_Duplicator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            CreateLine(i);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CreateLine(int hieght)
    {
        GameObject Cube;
        for (int i = 0; i < 10; i++)
        {
            Cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position=new Vector3(i,hieght,0);
            Material material=Cube.GetComponent<MeshRenderer>().material;
            material.color=Random.ColorHSV();

            Cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position=new Vector3(i,hieght,-9);
            material=Cube.GetComponent<MeshRenderer>().material;
            material.color=Random.ColorHSV();

            Cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position=new Vector3(0,hieght,-i);
            material=Cube.GetComponent<MeshRenderer>().material;
            material.color=Random.ColorHSV();
            
            Cube=GameObject.CreatePrimitive(PrimitiveType.Cube);
            Cube.transform.position=new Vector3(10,hieght,-i);
            material=Cube.GetComponent<MeshRenderer>().material;
            material.color=Random.ColorHSV();
        }
    }
}
