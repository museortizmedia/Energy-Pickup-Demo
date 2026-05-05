using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private GameStateSO gameState;
    [SerializeField] private IntEventChannelSO scoreUpdatedEvent;

    public void AddPoints(int amount)
    {
        gameState.currentScore += amount;

        scoreUpdatedEvent.RaiseEvent(
            gameState.currentScore
        );
    }
}