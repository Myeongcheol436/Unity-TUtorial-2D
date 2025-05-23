using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;

    public GameObject bulletPrefab; //�Ѿ� ������
    public Transform firePos; //�߻� ��ġ

    public float timer;
    public float cooldownTime;

    void Start() //1�� ���� �����ϴ� ���
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;    
    }

    void Update()  //���𰡸� �ٶ󺸴� ���
    {
        turretHead.LookAt(targetTf);

        timer += Time.deltaTime; //Ÿ�̸�
        if (timer >= cooldownTime)   //���� Ÿ�̸Ӱ� ��ٿ� �ð����� Ŀ���ٸ�
        {
            timer = 0f;
            Instantiate(bulletPrefab, firePos.position, firePos.rotation);
        }

    }
}
