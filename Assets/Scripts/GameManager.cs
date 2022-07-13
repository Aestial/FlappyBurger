using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GravityMovement gravityMovement;
    [SerializeField] private ObstacleSpawner obstacleSpawner;
    [SerializeField] private Canvas gameOverCanvas;
    [SerializeField] private Canvas scoreCanvas;

    [SerializeField] private TMPro.TMP_Text scoreText;
    [SerializeField] private TMPro.TMP_Text highScoreText;
    private int score;
    private bool isPlaying;

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        Pause();
        ShowGameOverScreen(true);
    }

    public void GameStart()
    {
        if (isPlaying) return;
        isPlaying = true;
        gravityMovement.enabled = true;
        obstacleSpawner.enabled = true;
    }

    public void Reset()
    {
        score = 0;
        scoreText.text = score.ToString();
        Time.timeScale = 1.0f;
        isPlaying = false;
        gravityMovement.Restart();
        gravityMovement.enabled = false;
        obstacleSpawner.enabled = false;
        ShowGameOverScreen(false);
    }
    
    void Start()
    {
        Reset();
    }

    private void Pause()
    {
        Time.timeScale = 0.0f;
        gravityMovement.enabled = false;
    }

    private void ShowGameOverScreen(bool show)
    {
        gameOverCanvas.enabled = show;
        scoreCanvas.enabled = !show;
        highScoreText.text = (show) ? score.ToString() : "";
    }
}
