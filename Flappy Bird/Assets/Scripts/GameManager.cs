using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; //Sahne yöneticisi kütüphanesi

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private TMP_Text highScoreText;

    private int score;

    private void Start()
    {
        score = 0;

        if (scoreText != null)
            scoreText.text = score.ToString();

        if (highScoreText != null)
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }
    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        
        if(score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highScore");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");//LoadScene("Game") veya LoadScene(0)
    }

    public void LoadMainMenuScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void NavigateToGame()
    {
        SceneManager.LoadScene("Game");
    }
}
