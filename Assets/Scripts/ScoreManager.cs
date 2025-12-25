using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _highScore;  

    private int score;

    public static ScoreManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        _currentScore.text = score.ToString();
        _highScore.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        RefreshHighScore();  
    }

    private void RefreshHighScore()  
    {
        int currentHigh = PlayerPrefs.GetInt("highScore", 0);
        if (score > currentHigh)
        {
            PlayerPrefs.SetInt("highScore", score);
            _highScore.text = score.ToString();
        }
    }

    public void RefreshScore()
    {
        score++;
        _currentScore.text = score.ToString();
        RefreshHighScore();
    }


    void Update()
    {
       
    }
}