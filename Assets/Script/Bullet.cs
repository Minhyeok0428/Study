using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float deltaTime = Time.deltaTime;
        transform.position += new Vector3(0, -_speed * deltaTime, 0);
    }
}
