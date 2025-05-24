using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private Transform _canvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject CubeRes = Resources.Load<GameObject>("Prefab/Cube");
            GameObject CubeGo = Instantiate(CubeRes, _canvas , false);
            CubeRes.GetComponent<Canvas>();

        }
    }
    
}
