using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class Score : MonoBehaviour
{
    public static Score intasce;

    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _highScoreText;

    private int _score;

    private void Awake()
    {
        if(intasce == null)
        {
            intasce = this;
        }
    }

    void Start()
    {
        _currentScoreText.text = _score.ToString();
        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        UpdateHighScore();
    }

    private void UpdateHighScore()
    {
    if(_score>PlayerPrefs.GetInt("HighScore")) 
        {
            PlayerPrefs.SetInt("HighScore", _score);
            _highScoreText.text= _score.ToString();
        }
   
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateHighScore();
    }
}
