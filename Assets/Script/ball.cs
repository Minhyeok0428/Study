using UnityEngine;

public class ball : MonoBehaviour
{
    // �߷� ���ӵ� (����: m/s^2)
    private float gravity = 9.81f;

    // �ӵ� (�ʱ� �ӵ��� 0)
    private float velocity = 0f;

    // ���� ���� ����
    private float startHeight;


    // ƨ��� ���� (�ݻ� ���)
    public float bounceFactor = 2.0f;

    // �ٴ� y ��ġ (��: y=0)
    private float groundHeight = -3.4f;

    private float _speed = 3.0f;

    void Start()
    {
        // �ʱ� ���� ���� (���� ���� �� ��ü�� y ��ġ)
        startHeight = transform.position.y;
    }

    void Update()
    {
        // deltaTime�� ����Ͽ� �ð��� ���� ���� ������ ó��
        float deltaTime = Time.deltaTime;

        // �߷¿� ���� �ӵ� ����
        velocity += gravity * deltaTime;

        // ��ġ ������Ʈ (�ӵ��� ���� y ��ġ ����)
        transform.position += new Vector3(0, -velocity * deltaTime, 0);

        // �ٴڿ� ������ ƨ���
        if (transform.position.y <= groundHeight)
        {
            transform.position = new Vector3(transform.position.x, groundHeight, transform.position.z); // �ٴ� ��ġ�� ����
            velocity = -velocity;

        }
        
    }
}
    
