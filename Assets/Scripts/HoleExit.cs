using UnityEngine;

public class HoleExit : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Collectables"))
        {
            gameManager.UpdateScore(other.gameObject.GetComponent<CollectableManager>().GetScore());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Collectables"))
        {
            Destroy(other.gameObject);
        }
    }
}