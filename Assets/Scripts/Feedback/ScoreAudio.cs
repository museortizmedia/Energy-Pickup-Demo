using UnityEngine;

public class ScoreAudio : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO scoreEvent;
    [SerializeField] private AudioSource audioSource;

    private void OnEnable()
    {
        scoreEvent.OnEventRaised += PlaySound;
    }

    private void OnDisable()
    {
        scoreEvent.OnEventRaised -= PlaySound;
    }

    private void PlaySound(int score)
    {
        audioSource.Play();
    }
}