using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;

    public int score;
    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = score.ToString();

        if (score > PlayerPrefs.GetInt("bestScore"))
        {
            PlayerPrefs.SetInt("bestScore", score);
        }
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
