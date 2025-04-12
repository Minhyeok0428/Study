using UnityEngine;

public class UIManager : MonoSingletone<UIManager>
{
    private Transform _canvasTrans;

    private void Awake()
    {
        _canvasTrans = transform;
    }
    public void CreateStartUI()
    {
        GameObject resGo = Resources.Load<GameObject>("Prefab/StartUI");
    }

}
