using UnityEngine;

public class PangPlayer : MonoBehaviour
{
    public enum STATE
    {
        IDLE,
        MOVE,
        HITTED,
    }

    private int _currentSpriteIndex;
    private float _accTime;

    [SerializeField]
    private Sprite[] IdleSprites;
    
    private Sprite[] WalkSprites;

    private SpriteRenderer _render;

    private STATE _currentState;

    private float _speed = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        Debug.Log("PangPlayerCreated");
        _currentState = STATE.IDLE;
        _render = GetComponentInChildren<SpriteRenderer>();
    }

    private void MoveInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * Time.deltaTime * _speed;
            _currentState = STATE.MOVE;
            _render.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * _speed;
            _currentState = STATE.MOVE;
            _render.flipX = false;
        }
    }
    private void IDLE_Action()
    {
        Debug.Log("Idle Action");
        MoveInput();

        _accTime = Time.deltaTime;

        if(_accTime >= 0.2f)
        {
            _currentSpriteIndex++;

            if (_currentSpriteIndex >= IdleSprites.Length)
                _currentSpriteIndex = 0;

            _render.sprite = IdleSprites[_currentSpriteIndex];

            _accTime = 0;
        }
        if(Input.GetMouseButtonDown(0))
        {
            GameObject resGO = Resources.Load<GameObject>("Prefab/Bullet");
            GameObject realGO = Instantiate(resGO);

            
        }    



    }    
    private void MOVE_Action()
    {
        Debug.Log("Move Action");
        MoveInput();
    }    
    private void HITTED_Action()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch(_currentState)
        {
            case STATE.IDLE:
                IDLE_Action();
                break;
            case STATE.MOVE:
                MOVE_Action();
                break;
            case STATE.HITTED:
                HITTED_Action();
                break;
        }

        if(Input.GetMouseButtonDown(0))
        {
            _currentState = STATE.MOVE;
        }
        if(Input.GetMouseButtonDown(1))
        {
            _currentState = STATE.IDLE;
        }    
    }
}
