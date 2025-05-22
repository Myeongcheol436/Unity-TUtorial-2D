using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    public GameObject destroyObj;

    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        Debug.Log("생성되었습니다.");
        CreateAmongus();

        Destroy(destroyObj, 3f); // 3초 뒤에 파괴시키는 기능
    }

    void OnDestroy()
    {
        Debug.Log("파괴되었습니다.");
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {count}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(count - 1).name}");
    }

}
