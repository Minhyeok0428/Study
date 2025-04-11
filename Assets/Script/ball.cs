using System.Runtime.CompilerServices;
using UnityEngine;

public class ball : MonoBehaviour
{
    private float _speed = 0; 
    private float _horizonSpeed = 3;
    private float _gravity = -9.8f;
    private bool _isLeftMove = false;
   
    void Start()
    {
        _speed = 10;   
    }

   private void Update()
    {

        if (_isLeftMove)
            LeftMove();
        else
            RightMove();

        if (transform.position.x < -8 || transform.position.x > 8)
        {
            if (transform.position.x > 8)
            {
                transform.position = new Vector3(8, transform.position.y, 0);

                if (transform.position.x < -8)
                    transform.position = new Vector3(-8, transform.position.y, 0);
            }
            _isLeftMove = !_isLeftMove;
        }

        if (transform.position.y < -3.3f)
        {
            _speed = 10;
            transform.position = new Vector3(transform.position.x, -3.29f , 0);
            return;
        }

        _speed += _gravity * Time.deltaTime;
        transform.position += new Vector3(0, _speed * Time.deltaTime, 0);
    }
    private void LeftMove()
    {
        transform.position += Vector3.left * Time.deltaTime * _horizonSpeed;
    }
    private void RightMove()
    {
        transform.position += Vector3.right * Time.deltaTime * _horizonSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D : " + other.gameObject.name);
    }
}

    
