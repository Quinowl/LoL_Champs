using UnityEngine;

public class TF_Stats : ChampionStats
{
    [Header("Q ability - Wild Cards")]
    public int qDamage = 50;
    public float qSpeed = 5f;
    public float qSpreadAngle = 15f;
    [Header("W ability - Pick a Card")]
    public float wSpeedRotation = 0.4f;
    public int wBlueManaRestore = 50;
    public int wRedAreaDamage = 40;
    public float wRedAreaRadius = 3f;
    public float wGoldStunDuration = 2f;
    [Header("E ability - Stacked Deck")]
    public int eBonusDamage = 40;
    public int eHitToTrigger = 4;
    [Header("R ability - Destiny")]
    public float rRange = 400f;
    public float rReavealTime = 4f;
    public float rTeleportDelay = 2f;
}