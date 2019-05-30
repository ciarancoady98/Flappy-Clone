using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    private int _currentScore = 0;
    public void IncrementScore()
    {
        _currentScore++;
        //Takes the score text and updates it to the new score value;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score : " + _currentScore.ToString();
    }
}
