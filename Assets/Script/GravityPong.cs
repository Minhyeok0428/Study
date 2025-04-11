using UnityEditor;
using UnityEngine;

public class GravityPong : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Physics2D.bounceThreshold = 10f;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("OnCollisionEnter2D : " + other.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D : " + other.gameObject.name);
    }
}
