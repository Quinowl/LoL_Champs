using UnityEngine;

public abstract class ChampionAbility : MonoBehaviour
{
    protected Champion _owner;
    protected ChampionCooldowns _cooldowns;

    public abstract KeyCode ActivationKey { get; }

    public void Initialize(Champion owner)
    {
        _owner = owner;
    }

    public virtual void TryActivate()
    {

    }

    public abstract void Activate();
}