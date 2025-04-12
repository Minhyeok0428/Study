using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private SpriteRenderer _render;
    [SerializeField]
    private Sprite[] _sprites;
    

    private float _accTime = 0;
    private int _currentIndex = 0;
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

        _accTime = Time.deltaTime;

        if (_accTime > 0.05f)
        {
            _currentIndex++;
            
            if(_currentIndex >= _sprites.Length)
                _currentIndex = 0;

            _render.sprite = _sprites[_currentIndex];

            _accTime = 0;
        }
    }
}
