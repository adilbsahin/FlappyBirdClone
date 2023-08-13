using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;

    public Text ScoreText;
    void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();
    }

    //skor artt�rma
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }

    //yeniden ba�latma
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
