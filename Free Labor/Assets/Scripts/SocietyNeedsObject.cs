using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SocietyNeeds", menuName = "Society/Society Needs")]
public class SocietyNeedsObject : ScriptableObject
{
    public float Wood;
    public float Stone;
    public float Water;
    public float RawMeat;
    public float CookedMeat;
}
