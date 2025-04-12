using UnityEngine;

public class Boom : MonoBehaviour
{
   
    [SerializeField]
    private SpriteRenderer _render;

    [SerializeField]
    private Sprite[] _sprites;

    private float _accTime;
    private int _currentIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _accTime += Time.deltaTime;

        if(_accTime > 0.1f)
        {
            _currentIndex++;

            if (_currentIndex >= _sprites.Length)
            {
                Destroy(gameObject);
                return;
            }

            _accTime = 0;
                
            _render.sprite = _sprites[_currentIndex];
        }
    }
}
