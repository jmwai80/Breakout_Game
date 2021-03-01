using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;
    public Text highScoreText;
    public bool gameOver;
    public GameObject gameOverPanel;
    public int numOfBricks;


    void Start ()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
        numOfBricks = GameObject.FindGameObjectsWithTag("brick").Length;

    }

    void Update ()
    {

    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        // check for no lives left and trigger end of the game
        if (lives <= 0){
            lives = 0;
            EndOfGame ();
        }
        livesText.text = "Lives: " + lives;
    }

    public void updateScore(int points){
        score += points;

        scoreText.text = "score: " + score;
    }

    public void UpdateNumberOfBricks(){
        numOfBricks --;
        if (numOfBricks <=0){
            EndOfGame();
        }
    }

    void EndOfGame(){
        gameOver = true;
        gameOverPanel.SetActive (true);
        int highScore = PlayerPrefs.GetInt("HIGHSCORE");
        if (score > highScore){
            PlayerPrefs.SetInt("HIGHSCORE", score);
            highScoreText.text = "New High Score! " + score;

        }
        else{
            highScoreText.text = "Current High Score is " + highScore + "\n" + "Can you beat it?";
        }
    }
    
    public void PlayAgain(){
        SceneManager.LoadScene ("Breakout_Game");
    }

    public void Quit(){
        SceneManager.LoadScene ("Start Menu");
    }
}
