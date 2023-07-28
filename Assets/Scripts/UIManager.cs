using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Canvases")]
    [SerializeField] private GameObject startScreenCanvas;
    [SerializeField] private GameObject gameScreenCanvas;
    [SerializeField] private GameObject endScreenCanvas;
    
    [Space]
    [SerializeField] private GameManager gameManger;

    public void StartGame()
    {
        startScreenCanvas.SetActive(false);
        gameScreenCanvas.SetActive(true);
        endScreenCanvas.SetActive(false);
    }

    public void EndGame()
    {
        startScreenCanvas.SetActive(false);
        gameScreenCanvas.SetActive(false);
        endScreenCanvas.SetActive(true);
    }

    public void StartScreenOn()
    {
        startScreenCanvas.SetActive(true);
        gameScreenCanvas.SetActive(false);
        endScreenCanvas.SetActive(false);
    }
}
