using UnityEngine;

public class HoleAudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;

    private void OnTriggerExit(Collider other)
    {
        audioSource.Play();
    }
}
