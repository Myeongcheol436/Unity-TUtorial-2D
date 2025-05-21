using Unity.VisualScripting;
using UnityEngine;

public class CalcuLator : MonoBehaviour
{
    public int number1,number2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int AddResult = AddMethod();
        int MinusResult = MinusMethod(); //함수 호출

        Debug.Log($"더한 값 :{AddResult} / 뺀 값 : {MinusResult}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int AddMethod()
    {
        // 지역 변수 result
        int result = number1 + number2;
        
        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        
        return result;

    }
}
