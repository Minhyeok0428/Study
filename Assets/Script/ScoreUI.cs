using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI _scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _scoreText = GetComponentInChildren<TextMeshProUGUI>();    
    }
    public void ChangeScore(int score)
    {
        _scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeScore(4885);
        }
    }
}
