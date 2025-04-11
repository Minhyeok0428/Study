using System.Runtime.CompilerServices;
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
    [SerializeField]
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

       else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * _speed;
            _currentState = STATE.MOVE;
            _render.flipX = false;
        }
        else
        {
            _currentState = STATE.IDLE;
        }
    }
    private void IDLE_Action()
    {
        MoveInput();
        SpriteAnimation(IdleSprites);
        

        _accTime += Time.deltaTime;

        if(_accTime >= 0.2f)
        {
            _currentSpriteIndex++;

            if (_currentSpriteIndex >= IdleSprites.Length)
                _currentSpriteIndex = 0;

            _render.sprite = IdleSprites[_currentSpriteIndex];

            _accTime = 0;
        }



    }
    private void MOVE_Action()
    {
        Debug.Log("Move Action");
        MoveInput();
        SpriteAnimation(WalkSprites);

        _accTime += Time.deltaTime;

        if (_accTime >= 0.2f)
        {
            _currentSpriteIndex++;

            if (_currentSpriteIndex >= IdleSprites.Length)
                _currentSpriteIndex = 0;

            _render.sprite = WalkSprites[_currentSpriteIndex];

            _accTime = 0;

        }
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject resGO = Resources.Load<GameObject>("Prefab/Bullet");
            GameObject realGO = Instantiate(resGO);

            realGO.transform.position = transform.position + new Vector3(0, 0.5f, 0);
        }


        if (Input.GetMouseButtonDown(0))
        {
            _currentState = STATE.MOVE;
        }
        if(Input.GetMouseButtonDown(1))
        {
            _currentState = STATE.IDLE;
        }    
    }
    private float _changeTime = 0.2f;
    private int _aniIndex = 0;

    private void SpriteAnimation(Sprite[] sprites)
    {
        _accTime += Time.deltaTime;

        if(_accTime >= _changeTime)
        {
            if(_render != null)
                _render.sprite = sprites[_aniIndex];
        }
    }
}


