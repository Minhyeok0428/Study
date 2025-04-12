using UnityEngine;

public class MonoSingletone<T> : MonoBehaviour where T : MonoSingletone<T>
{
    private static T _instance;
  
    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindAnyObjectByType<T>();

                GameObject go = new GameObject("Singletone " + typeof(T).ToString());
                go.AddComponent<T>();
            }

            DontDestroyOnLoad(_instance);

            return _instance;
        }
    }


}
