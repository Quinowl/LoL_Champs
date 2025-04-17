using UnityEngine;

[RequireComponent(typeof(ChampionAutoAttack), typeof(ChampionMovement))]
public abstract class Champion : MonoBehaviour
{
    [SerializeField] protected ChampionStats _stats;
    [SerializeField] protected ChampionMovement _movement;
    [SerializeField] protected ChampionAutoAttack _autoAttack;

    protected ChampionCooldowns _cooldowns;
    public ChampionCooldowns Cooldowns => _cooldowns;

    protected virtual void Awake()
    {
        _cooldowns = new ChampionCooldowns();
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }
}