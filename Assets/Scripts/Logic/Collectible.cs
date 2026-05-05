using System.Data;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Collectible : MonoBehaviour
{
    [SerializeField] private ScoreSystem scoreSystem;

    private Collider _collider;

    void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Evaluate();
    }

    public void Evaluate()
    {
        scoreSystem.AddPoints(10);
        Destroy(gameObject);
    }
}