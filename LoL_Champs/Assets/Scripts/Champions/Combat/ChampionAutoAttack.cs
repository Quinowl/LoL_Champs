using System;
using UnityEngine;

public class ChampionAutoAttack : MonoBehaviour
{
    [SerializeField] private int _damage;

    private float _lastAttackTime;
    private Transform _target;

    public event Action<GameObject> OnHit;

    public void SetTarget(Transform newTarget) => _target = newTarget;

    private void Attack()
    {
        if (_target.TryGetComponent(out Damageable damageable))
        {
            damageable.TakeDamage(_damage);
            OnHit?.Invoke(_target.gameObject);
        }
    }
}