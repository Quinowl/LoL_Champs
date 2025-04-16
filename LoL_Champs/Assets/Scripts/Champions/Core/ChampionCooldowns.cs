using System.Collections.Generic;
using UnityEngine;

public class ChampionCooldowns : MonoBehaviour
{
    private Dictionary<string, float> _cooldowns;

    /// <summary> Inicia el cooldown de la habilidad o hechizo que digamos en la key. </summary>
    public void SetCooldown(string key, float duration) => _cooldowns[key] = Time.time + duration;

    /// <summary> Devuelve verdadero o falso si la habilidad o hechizo que digamos en la key sigue en cooldown. </summary>
    public bool IsOnCooldown(string key) => _cooldowns.TryGetValue(key, out float endTime) && Time.time < endTime;

    /// <summary> Devuelve el cooldown restante de la habilidad o hechizo que digamos en la key. </summary>
    public float GetRemainingCooldown(string key) => _cooldowns.TryGetValue(key, out float endTime) ? Mathf.Max(0, endTime - Time.time) : 0;

    /// <summary> Resetea el cooldown de la habilidad o hechizo que digamos en la key. </summary>
    public void ResetCooldown(string key)
    {
        if (_cooldowns.ContainsKey(key)) _cooldowns[key] = 0;
    }
}