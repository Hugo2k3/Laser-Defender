using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI MaxScoreText;
    ScoreKeeper scoreKeeper;
    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
     void Start()
    {
      

        scoreText.text = "Scored:" + scoreKeeper.getScore();

    }
    private void Update()
    {
        scoreKeeper.HighScore = scoreKeeper.getScore();
        MaxScoreText.text = "High Scored:" + scoreKeeper.HighScore;
        
    }
}
