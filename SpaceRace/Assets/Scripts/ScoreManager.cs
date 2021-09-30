using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;

    void Start()
    {
        score = 0;
        UpdateScore(0);
    }
    

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
