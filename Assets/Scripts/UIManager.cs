using System.Collections;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [Header("Canvases")]
    [SerializeField] private GameObject startScreenCanvas;
    [SerializeField] private GameObject gameScreenCanvas;
    [SerializeField] private GameObject endScreenCanvas;
    
    [Space]
    [Header("Animated Text")]
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject scoreForAnimation;
    private Transform holeTransform;

    public void StartGame(GameObject hole)
    {
        holeTransform = hole.transform;
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

    public void UpdateScore(int currentScore, int newScore)
    {
        scoreText.text = "Score:\n" + currentScore;

        if (newScore == 0) return;
        var scoreTextAnimated = Instantiate(scoreForAnimation, holeTransform.transform.position,
            Quaternion.identity);

        scoreTextAnimated.GetComponentInChildren<TextMeshProUGUI>().text = "+" + newScore;
        
        Destroy(scoreTextAnimated, 0.5f);
    }
}
