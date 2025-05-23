using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; //총알 프리팹
    public Transform firePos; //발사 위치

    public float timer;
    public float cooldownTime;

    void Start() //1번 실행 셋팅하는 기능
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()  //무언가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime; //타이머
        if (timer >= cooldownTime)   //현재 타이머가 쿨다운 시간보다 커졌다면
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
