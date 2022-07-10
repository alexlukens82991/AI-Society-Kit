using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewUnitSettings", menuName = "Units/Unit Settings", order = 0)]
public class UnitSettingsObject : ScriptableObject
{
    public float HealthThreshold;
    public float EnergyThreshold;
    public float HungerThreshold;
    public float ThirstThreshold;
}
