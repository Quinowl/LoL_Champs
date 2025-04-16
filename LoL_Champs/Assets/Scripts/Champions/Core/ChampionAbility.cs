using UnityEngine;

public abstract class ChampionAbility : MonoBehaviour {

    protected Champion _owner;
    
    public abstract KeyCode ActivationKey { get; }

    public void Initialize(Champion owner) {
        _owner = owner;
    }

    public virtual void TryActivate() {

    }

    public abstract void Activate();
}