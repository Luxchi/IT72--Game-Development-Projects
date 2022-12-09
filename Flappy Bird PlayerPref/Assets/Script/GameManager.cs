using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    private Player player;
    private Spawner spawner;

    public Text scoreText;
    //public Text highscoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject getReady;
    public GameObject scoreBoard;
    public GameObject tryAgain;
    public Text highScore;
    public int score { get; private set; }

    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();

        Pause();
    }

    public void Play()
    {
        score = 0;  
        scoreText.text = score.ToString();
        highScore.text  = PlayerPrefs.GetInt("HighScore",0).ToString();

        playButton.SetActive(false);
        getReady.SetActive(false);
        gameOver.SetActive(false);
        scoreBoard.SetActive(false);
        tryAgain.SetActive(false);

        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++) {
            Destroy(pipes[i].gameObject);
        }
    }

    public void GameOver()
    {

        gameOver.SetActive(true);
        scoreBoard.SetActive(true);
        tryAgain.SetActive(true);

        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();

        
    }

     public void TryAgain(){
        Play();
     }

        public void clickSave()
        {
            if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScore.text = score.ToString();
        }
            int MyInteger = Convert.ToInt32(scoreText.text);
            PlayerPrefs.SetInt("scorepass", MyInteger);
            SceneManager.LoadScene("Scoreboard");
        }
   

}