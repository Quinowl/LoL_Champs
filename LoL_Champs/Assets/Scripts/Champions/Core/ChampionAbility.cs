using UnityEngine;

public abstract class ChampionAbility : MonoBehaviour
{
    [SerializeField] protected string _abilityKey;
    [SerializeField] protected float _cooldownDuration;

    protected Champion _owner;
    protected ChampionCooldowns _cooldowns;

    public abstract KeyCode ActivationKey { get; }

    public void Initialize(Champion owner)
    {
        _owner = owner;
        if (!string.IsNullOrEmpty(_abilityKey)) _owner.Cooldowns.SetCooldown(_abilityKey, _cooldownDuration);
    }

    public virtual void TryActivate()
    {
        if (!string.IsNullOrEmpty(_abilityKey) && _owner.Cooldowns.IsOnCooldown(_abilityKey)) return;
        Activate();
        if (!string.IsNullOrEmpty(_abilityKey)) _owner.Cooldowns.SetCooldown(_abilityKey, _cooldownDuration);
    }

    public abstract void Activate();
}