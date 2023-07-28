using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UIManager uiManager;

    private void Start()
    {
        uiManager.StartScreenOn();
    }

    public void StartGame()
    {
        uiManager.StartGame();
    }

    public void RestartGame()
    {
        uiManager.StartGame();
    }
}
