using UnityEngine;
using UnityEngine.UIElements;

public class StudyComponent : MonoBehaviour
{
    GameObject obj;

    public string change_Name;

    void Start()
    {

        obj = GameObject.Find("Main Camera");
        obj.name = change_Name;
        //obj.Transform.Position = 5;
    }
}
