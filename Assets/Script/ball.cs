using UnityEngine;

public class ball : MonoBehaviour
{
    // 중력 가속도 (단위: m/s^2)
    private float gravity = 9.81f;

    // 속도 (초기 속도는 0)
    private float velocity = 0f;

    // 낙하 시작 높이
    private float startHeight;


    // 튕기는 정도 (반사 계수)
    public float bounceFactor = 2.0f;

    // 바닥 y 위치 (예: y=0)
    private float groundHeight = -3.4f;

    private float _speed = 3.0f;

    void Start()
    {
        // 초기 높이 저장 (게임 시작 시 객체의 y 위치)
        startHeight = transform.position.y;
    }

    void Update()
    {
        // deltaTime을 사용하여 시간에 따른 물리 연산을 처리
        float deltaTime = Time.deltaTime;

        // 중력에 의한 속도 증가
        velocity += gravity * deltaTime;

        // 위치 업데이트 (속도에 따라 y 위치 변경)
        transform.position += new Vector3(0, -velocity * deltaTime, 0);

        // 바닥에 닿으면 튕기기
        if (transform.position.y <= groundHeight)
        {
            transform.position = new Vector3(transform.position.x, groundHeight, transform.position.z); // 바닥 위치로 고정
            velocity = -velocity;

        }
        
    }
}
    
