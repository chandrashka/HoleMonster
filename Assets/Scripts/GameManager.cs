using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;
    [SerializeField] private LevelManager levelManager;

    private void Start()
    {
        uiManager.StartScreenOn();
    }

    public void StartGame()
    {
        uiManager.StartGame();
        levelManager.StartGame();
    }

    public void EndGame()
    {
        levelManager.EndGame();
        uiManager.EndGame();
    }

    public void RestartGame()
    {
        uiManager.StartGame();
    }
}
