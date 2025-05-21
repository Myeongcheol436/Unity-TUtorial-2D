using UnityEngine;

public class SstudLog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created 업데이트()실행전 먼저 실행한다.
    void Start()
    {
        Debug.Log("Strat 함수 실행");
        Debug.LogWarning("Strat 함수 실행");
        Debug.LogError("Strat 함수 실행");
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}


