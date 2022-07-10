using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionPhase : StateMachineComponent
{
    public UnitSettingsObject Settings;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        CurrentUnitStats currentUnitStats = new(animator);

        bool selfCareNeeded = false;

        if (currentUnitStats.Health < Settings.HealthThreshold)
        {
            selfCareNeeded = true;
        }
        else if (currentUnitStats.Thirst < Settings.ThirstThreshold)
        {
            selfCareNeeded = true;
        }
        else if (currentUnitStats.Hunger < Settings.HungerThreshold)
        {
            selfCareNeeded = true;
        }
        else if (currentUnitStats.Energy < Settings.EnergyThreshold)
        {
            selfCareNeeded = true;
        
        
        }
        string targetState;

        if (selfCareNeeded)
        {
            targetState = StateDictionary.SELF_CARE;
        }
        else
        {
            targetState = StateDictionary.CHECK_SOCIETY_NEEDS;
        }

        animator.SetTrigger(targetState);
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        
    }
}
