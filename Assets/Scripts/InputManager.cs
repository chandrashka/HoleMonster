using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    
    public void StartGame()
    {
        gameManager.StartGame();
    }

    public void RestartGame()
    {
        gameManager.RestartGame();
    }
}
