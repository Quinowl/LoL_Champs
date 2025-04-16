using UnityEngine;

public abstract class Champion : MonoBehaviour
{
    [SerializeField] protected ChampionStats _stats;
    [SerializeField] protected ChampionMovement _movement;
    [SerializeField] protected ChampionAutoAttack _autoAttack;

    protected ChampionCooldowns _cooldownManager;

    protected virtual void Awake()
    {
        _cooldownManager = new ChampionCooldowns();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }
}