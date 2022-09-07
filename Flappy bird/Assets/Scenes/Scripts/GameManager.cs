using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject gameOver;
    public GameObject PlayButton;
    private int score;
    public void GameOver()
    {
        gameOver.SetActive(true);
        PlayButton.SetActive(true);
        Pause();
    }
    public void IncreaseScore()
    {
        score++;    
        scoreText.text = score.ToString();
    }
    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }
    public void Play()
    {
        score = 0;
        scoreText.text =score.ToString();
        gameOver.SetActive(false);
        PlayButton.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
        Pipes[] pipes  = FindObjectsOfType<Pipes>();
        for(int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }
}
