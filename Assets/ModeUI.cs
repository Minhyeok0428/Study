using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ModeUI : MonoBehaviour
{
    [SerializeField]
    Button _TimeAttackButton;
    [SerializeField]
    Button _stageButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _TimeAttackButton.onClick.AddListener(OnClickTimeAttackMode);
        _stageButton.onClick.AddListener(OnClickStageMode);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnClickTimeAttackMode()
    {
        Debug.Log("OnClickTimeAttackMode");

        StartCoroutine(LoadSceneAsync("GameScene"));

        SceneManager.LoadScene("GameScene");

        GameObject resGO = Resources.Load<GameObject>("Prefab/ModeUI");
        Instantiate(resGO);
        
    }
    private void OnClickStageMode()
    {

    }
    private IEnumerator LoadSceneAsync(string sceneName)
    {
        yield return SceneManager.LoadSceneAsync(sceneName);
    }

}
