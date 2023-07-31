using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private LevelManager levelManager;
    private int currentScore;
    private const int FinalScore = 600;
    private List<int> scoreForIncreasing;
    
    private void Start()
    {
        uiManager.StartScreenOn();
    }

    public void StartGame()
    {
        currentScore = 0;
        scoreForIncreasing = new List<int> { 50, 200, 400, 550 };
        var hole = levelManager.StartGame();
        uiManager.StartGame(hole);
        uiManager.UpdateScore(currentScore, 0);
    }

    private void EndGame()
    {
        levelManager.EndGame();
        uiManager.EndGame();
    }

    public void RestartGame()
    {
        StartGame();
    }

    public void UpdateScore(int score)
    {
        currentScore += score;
        uiManager.UpdateScore(currentScore, score);
        if (currentScore >= FinalScore)
        {
            EndGame();
        }

        var scoreToDelete = -1;
        foreach (var tempScore in scoreForIncreasing.Where(tempScore => currentScore >= tempScore))
        {
            levelManager.IncreaseHole();
            scoreToDelete = scoreForIncreasing.IndexOf(tempScore);
        }

        if (scoreToDelete != -1)
        {
            scoreForIncreasing.Remove(scoreForIncreasing[scoreToDelete]);
        }
    }
}
