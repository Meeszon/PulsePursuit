using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    
    public void addScore()
    {
        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void resetScore()
    {
        playerScore = 0;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
       
    }
}
