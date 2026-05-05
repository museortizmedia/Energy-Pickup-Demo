using TMPro;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private IntEventChannelSO scoreEvent;
    [SerializeField] private TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        scoreEvent.OnEventRaised += UpdateUI;
    }

    private void OnDisable()
    {
        scoreEvent.OnEventRaised -= UpdateUI;
    }

    private void UpdateUI(int score)
    {
        scoreText.text = "Score: " + score;
    }
}