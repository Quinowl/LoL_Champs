using UnityEngine;
using UnityEngine.AI;

public class ChampionMovement : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _agent;

    void Awake()
    {
        if (!_agent) _agent = GetComponent<NavMeshAgent>();
        _agent.updateRotation = false;
    }

    public void MoveTo(Vector3 newPosition)
    {
        _agent.transform.forward = newPosition - _agent.transform.position;
        _agent.SetDestination(newPosition);
    }
    public void Stop() => _agent.ResetPath();
    public bool IsMoving() => _agent.hasPath;
}