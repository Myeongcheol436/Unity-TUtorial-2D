using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float MoveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.name);

        //this.transform.position = this.transform.position + Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position = this.transform.position + Vector3.forward * MoveSpeed;

        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.position += Vector3.forward * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.A))
        //{   
        //    transform.position += Vector3.left * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.position += Vector3.back * MoveSpeed * Time.deltaTime;
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * MoveSpeed * Time.deltaTime; 
        //}

        float h = Input.GetAxis("Horizontal"); //가로세로
        float v = Input.GetAxis("Vertical"); //수직 위 아래

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입력 : {dir}");

        transform.position += dir * MoveSpeed * Time.deltaTime;
        }
    }

