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
    //private int[] array_a = new int[6] {1,2,3,4,5,6}; //�ƹ��͵� �� ������ �����̺�
    //int[] array_b = new int[5];

    void Start()
    {
        //list_Number.Add(11);
        //list_Number.Add(22);
        //list_Number.Add(33);
        //list_Number.Add(44);
        //list_Number.Add(55);

        //Debug.Log($"���� List�� �ִ� ������ �� : {list_Number.Count}");
        //Debug.Log($"���� List�� �ִ� ������ ������ : {list_Number [list_Number.Count - 1]}");

        //// �迭
        //Debug.Log($"Array�� ù��° �� : {array_Number[0]} �Դϴ�.");
        //Debug.Log($"Array�� �׹�° �� : {array_Number[3]} �Դϴ�.");
        //Debug.Log($"Array�� �����̺� ���� : {array_a[2]} �Դϴ�.");

        //Debug.Log($"���� Array�� ���̴� : {array_Number.Length}");
        //Debug.Log($"���� Array�� �ִ� ������ ������ : {array_Number[array_Number.Length - 1]}");

    }
}
