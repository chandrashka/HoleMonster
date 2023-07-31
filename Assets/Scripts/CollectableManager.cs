using UnityEngine;

public class CollectableManager : MonoBehaviour
{
    [SerializeField] private CollectableScriptableObject collectableScriptableObject;

    public int GetScore()
    {
        return collectableScriptableObject.score;
    }
}