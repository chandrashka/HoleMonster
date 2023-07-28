using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject levelPrefab;
    private readonly List<GameObject> _levelItems = new ();
    private readonly Vector3 _startPosition = new(0, 0, 0);

    public void StartGame()
    {
        _levelItems.Add(Instantiate(levelPrefab, _startPosition, Quaternion.identity));
    }

    public void EndGame()
    {
        foreach (var item in _levelItems)
        {
            Destroy(item);
        }
    }
}
