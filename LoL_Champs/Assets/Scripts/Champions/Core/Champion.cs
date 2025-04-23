using UnityEngine;

[RequireComponent(typeof(ChampionAutoAttack), typeof(ChampionMovement))]
public abstract class Champion : MonoBehaviour
{
    [SerializeField] protected ChampionStats _stats;
    [SerializeField] protected ChampionMovement _movement;
    [SerializeField] protected ChampionAutoAttack _autoAttack;
    [SerializeField] protected ChampionInput _input;
    [SerializeField] protected ChampionMediator _mediator;

    protected ChampionCooldowns _cooldowns;

    public ChampionStats Stats => _stats;
    public ChampionCooldowns Cooldowns => _cooldowns;
    public ChampionMovement Movement => _movement;
    public ChampionAutoAttack AutoAttack => _autoAttack;
    public ChampionMediator Mediator => _mediator;

    protected virtual void Awake()
    {
        // _cooldowns = new ChampionCooldowns();
        _input.Initialize(this);
        _mediator.Initialize(this);
    }

    protected virtual void Start()
    {

    }

    protected virtual void Update()
    {

    }
}