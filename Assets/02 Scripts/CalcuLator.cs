using Unity.VisualScripting;
using UnityEngine;

public class CalcuLator : MonoBehaviour
{
    public int number1,number2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int AddResult = AddMethod();
        int MinusResult = MinusMethod(); //�Լ� ȣ��

        Debug.Log($"���� �� :{AddResult} / �� �� : {MinusResult}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int AddMethod()
    {
        // ���� ���� result
        int result = number1 + number2;
        
        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        
        return result;

    }
}
