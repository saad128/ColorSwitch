using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private TextMeshProUGUI gameOverText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    [SerializeField] private bool isGameActive = true;
    [SerializeField] private GameObject restartGameButton;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        UpdateScore(0);
    }

    public bool GetIsGameActive() 
    {
        return isGameActive;
    }

    public void SetIsGameActive(bool isGameActive)
    {
        this.isGameActive = isGameActive;
    }
  
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        restartGameButton.SetActive(true);
        isGameActive = false;
    }
}
