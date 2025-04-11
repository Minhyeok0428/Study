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
        transform.position += Vector3.up * _speed * Time.deltaTime;

        if(transform.position.y > 10)
            Destroy(gameObject);
    }
}
