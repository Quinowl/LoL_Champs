using System;
using UnityEngine;

public class ChampionAutoAttack : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _attackRange;
    [SerializeField] private float _attackCooldown;

    private float _lastAttackTime;
    private Damageable _target;

    public event Action<GameObject> OnHit;

    public void SetTarget(Damageable newTarget) => _target = newTarget;

    void Update()
    {
        if (!_target) return;
        if (Vector3.Distance(transform.position, _target.transform.position) <= _attackRange &&
            Time.time - _lastAttackTime >= _attackCooldown)
        {
            Attack();
            _lastAttackTime = Time.time;
        }
    }

    private void Attack()
    {
        if (_target)
        {
            // Debug.Log($"Atacamos a {_target.name}");
            _target.TakeDamage(_damage);
            OnHit?.Invoke(_target.gameObject);
        }
    }
}