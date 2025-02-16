using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Score : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        UpdateScoreText();
    }

    public void Scoreincrease(int total)

    { score += total;
        UpdateScoreText();

    }


     void UpdateScoreText ()
    {
        scoreText.text = "SCORE: " + score;  
    }




}



