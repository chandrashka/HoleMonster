using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject levelPrefab;
    private GameObject level;
    private readonly Vector3 startPosition = new(0, 0, 0);
    private GameObject hole;
    private const float Scaler = 1.3f;
    private const int MaxHoleSize = 4;
    private int holeSize;
    
    public GameObject StartGame()
    {
        level = Instantiate(levelPrefab, startPosition, Quaternion.identity);
        hole = level.GetComponentInChildren<HoleController>().gameObject;
        holeSize = 0;
        return hole;
    }

    public void EndGame()
    {
        Destroy(level);
    }

    public void IncreaseHole()
    {
        if (holeSize >= MaxHoleSize) return;
        hole.transform.localScale *= Scaler;
        holeSize++;
    }
}
