using UnityEngine;

public class PangPlayer : MonoBehaviour
{

    private STATE _currentState;
    public enum STATE
    {
        IDLE,
        MOVE,
        HITTED,
    }
    [SerializeField]
    private Sprite IdleSprites;

    [SerializeField]
    private Sprite WalkSprites;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(_currentState)
        {
            case STATE.IDLE:
                break;
            case STATE.MOVE:
                break;
            case STATE.HITTED:
                break;
        }
    }
    private void IDLE_Action()
    {

    }
}
