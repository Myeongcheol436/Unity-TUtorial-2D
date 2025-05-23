using UnityEngine;
using UnityEngine.UIElements;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;

    public Mesh msh;
    public Material mat;

    //public Transform objTf;

    //public string change_Name;

    void Start()
    {
        obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
        CreateCube("Hello World");
        CreateCube();
    }

    public void CreateCube(string name = "Cube")
    {
        obj = new GameObject(name);

        obj.AddComponent<MeshFilter>();
        obj.AddComponent<MeshRenderer>();
        obj.AddComponent<BoxCollider>();
        //string[] monster = { "슬라임, 사막뱀, 악마" };
        //int[] monster_level = new int[4];
        //monster_level[0] = 1;
        //monster_level[1] = 6;
        //monster_level[2] = 20;


        //obj = GameObject.FindGameObjectWithTag("Player");

        //objTf = GameObject.FindGameObjectWithTag("Player").transform;

        //Debug.Log($"<Color=#ff0000>이름 : {obj.name}</Color>");

        //Debug.Log($"태그 :{obj.tag}");
        //Debug.Log($"위치 : {obj.transform.position}");
        //Debug.Log($"회전 : {obj.transform.rotation}");
        //Debug.Log($"크기 : {obj.transform.localScale}");

        //Debug.Log($"Mesh 데이터 : {obj.GetComponent<MeshFilter>().mesh}");

        //Debug.Log($"Material 데이터 : {obj.GetComponent<MeshRenderer>().material}");

        //obj.GetComponent<MeshRenderer>().enabled = false;

        //obj.SetActive(false);
        //objTf.gameObject.SetActive(false);

        obj = new GameObject("Cube");

        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;

        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;

        obj.AddComponent<BoxCollider>();
        obj.GetComponent<MeshFilter>();
    }
}
