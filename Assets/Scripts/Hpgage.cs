using UnityEngine;

public class Hpgage : MonoBehaviour
{
    [SerializeField]
    private Transform _target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 uiPosition = Camera.main.WorldToScreenPoint(_target.position);
        (transform as RectTransform).position = uiPosition + Vector2.up * 100;
    }
}
