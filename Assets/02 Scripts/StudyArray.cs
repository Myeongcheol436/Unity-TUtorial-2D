using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    int number1 = 1;
    private int njumber2 = 2;

    public int number3 = 3;
    [SerializeField]
    private int number4 = 4;
    [SerializeField] private int number5 = 5;

    //List<int> list_Number = new List<int>();

    //public int[] array_Number = new int[5] { 12, 23, 34, 45, 56 };
    //private int[] array_a = new int[6] {1,2,3,4,5,6}; //아무것도 안 적으면 프라이빗
    //int[] array_b = new int[5];

    void Start()
    {
        //list_Number.Add(11);
        //list_Number.Add(22);
        //list_Number.Add(33);
        //list_Number.Add(44);
        //list_Number.Add(55);

        //Debug.Log($"현재 List에 있는 데이터 수 : {list_Number.Count}");
        //Debug.Log($"현재 List에 있는 마지막 테이터 : {list_Number [list_Number.Count - 1]}");

        //// 배열
        //Debug.Log($"Array의 첫번째 값 : {array_Number[0]} 입니다.");
        //Debug.Log($"Array의 네번째 값 : {array_Number[3]} 입니다.");
        //Debug.Log($"Array의 프라이빗 값은 : {array_a[2]} 입니다.");

        //Debug.Log($"현재 Array의 길이는 : {array_Number.Length}");
        //Debug.Log($"현재 Array에 있는 마지막 테이터 : {array_Number[array_Number.Length - 1]}");

    }
}
