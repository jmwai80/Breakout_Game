using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int score;
    public Text livesText;
    public Text scoreText;

    void Start ()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;

    }

    void Update ()
    {

    }

    public void UpdateLives(int changeInLives)
    {
        lives += changeInLives;

        // check for no lives left and trigger end of the game

        livesText.text = "Lives: " + lives;
    }

    public void updateScore(int points){
        score += points;

        Debug.Log("IM here" + score);

        scoreText.text = "score: " + score;
    }
}
