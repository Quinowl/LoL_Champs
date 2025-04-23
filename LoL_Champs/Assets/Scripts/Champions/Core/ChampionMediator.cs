using System;
using UnityEngine;

public class ChampionMediator : MonoBehaviour
{
    private Champion _champion;
    private Damageable _target;

    private void Update()
    {
        if (!_target) return;
        if (Vector3.Distance(transform.position, _target.transform.position) <= _champion.Stats.attackRange)
        {
            _champion.Movement.Stop();
            _champion.AutoAttack.SetTarget(_target);
        }
        else _champion.Movement.MoveTo(_target.transform.position);
    }

    public void Initialize(Champion champion) => _champion = champion;

    public void OnClick(RaycastHit hit)
    {
        if (hit.collider.TryGetComponent(out Damageable damageable)) _target = damageable;
        else _target = null;
        _champion.Movement.MoveTo(new Vector3(hit.point.x, transform.position.y, hit.point.z));
    }
}