using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/CollectableScriptableObject", order = 1)]
public class CollectableScriptableObject : ScriptableObject
{
    public int score;
}