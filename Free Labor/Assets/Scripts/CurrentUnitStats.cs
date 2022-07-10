using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CurrentUnitStats
{
    public float Health;
    public float Energy;
    public float Hunger;
    public float Thirst;

    public CurrentUnitStats(Animator animator)
    {
        Health = animator.GetFloat("Health");
        Energy = animator.GetFloat("Energy");
        Hunger = animator.GetFloat("Hunger");
        Thirst = animator.GetFloat("Thirst");
    }

    public override string ToString()
    {
        string str = "Unit Stats:\n";
        str = "Health: " + Health + "\n";
        str = "Energy: " + Energy + "\n";
        str = "Hunger: " + Hunger + "\n";
        str = "Thirst: " + Thirst;

        return str;
    }
}
