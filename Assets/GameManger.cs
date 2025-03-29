using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    [SerializeField]
    private Button _startButton;
    [SerializeField]
    private Transform _canvasTrans;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startButton.onClick.AddListener(OnClickStartButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnClickStartButton()
    {
        _startButton.gameObject.SetActive(true);

        Debug.Log("OnClickStartButton");

        GameObject resGo = Resources.Load<GameObject>("Prefab/ModeUI");
        Debug.Log("resGo " + resGo);

        GameObject SceneGO = Instantiate(resGo, _canvasTrans, false);
        ModeUI uiComp = SceneGO.GetComponent<ModeUI>();
        

    }
}
