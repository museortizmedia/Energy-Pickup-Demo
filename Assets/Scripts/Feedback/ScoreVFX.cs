using System.Collections;
using UnityEngine;

public class ScoreVFX : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO scoreEvent;
    [SerializeField] private ParticleSystem particles;

    [SerializeField]
    private float effectDuration = 2f;

    private Coroutine currentEffectRoutine;

    private void Awake()
    {
        particles.Stop();
    }

    private void OnEnable()
    {
        scoreEvent.OnEventRaised += PlayVFX;
    }

    private void OnDisable()
    {
        scoreEvent.OnEventRaised -= PlayVFX;
    }

    private void PlayVFX(int score)
    {
        if (currentEffectRoutine != null)
        {
            StopCoroutine(currentEffectRoutine);
        }

        currentEffectRoutine = StartCoroutine(PlayEffectRoutine());
    }

    private IEnumerator PlayEffectRoutine()
    {
        particles.Play();

        yield return new WaitForSeconds(
            effectDuration
        );

        particles.Stop();

        currentEffectRoutine = null;
    }
}