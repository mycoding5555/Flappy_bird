using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScore;
    [SerializeField] private TextMeshProUGUI _higtScore;

    private int score;

    public static ScoreManager instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
      void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start ()
    {
        _currentScore.text= score.ToString();
        _higtScore.text= PlayerPrefs.GetInt("highScore",0).ToString();
        RefreshHightScore();
    }

  
    // Update is called once per frame
     private void RefreshHightScore()
    {
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
            _higtScore.text = score.ToString();
        }
        
    }

    public void RefreshScore()
    {
        score++;
        _currentScore.text = score.ToString();
        RefreshHightScore();

    }

    void Update()
    {
        
    }
}
