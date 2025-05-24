using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class StartUI : MonoBehaviour
{
    [SerializeField]
    private Button _Button;

    [SerializeField]
    private Transform _canvasTrans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _Button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject SceneRes = Resources.Load<GameObject>("Prefab/StartUI");
            GameObject SceneGo = Instantiate(SceneRes, _canvasTrans, false);
            SceneRes.GetComponent<Canvas>();
        }
    }
}
