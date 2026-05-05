using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Blueprint/Event Channels/Int Event")]
public class IntEventChannelSO : ScriptableObject
{
    public Action<int> OnEventRaised;

    public void RaiseEvent(int value)
    {
        OnEventRaised?.Invoke(value);
    }
}