using UnityEngine;

public class ChampionStats : ScriptableObject
{
    [Header("Movement fields")]
    public float moveSpeed = 10f;
    [Header("Combat fields")]
    public int maxHealth = 100;
    public int autoAttackDamage = 5;
    public float attackRange = 10f;
    [Header("Cooldowns")]
    public float attackCooldown = 0.25f;
    public float qCooldown = 1f;
    public float wCooldown = 1f;
    public float eCooldown = 1f;
    public float rCooldown = 2f;
}