using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gather : StateMachineComponent
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        int primaryNeed = animator.GetInteger("PrimaryNeed");
        string primaryNeedString = StateDictionary.GetNeed(primaryNeed);

        switch (primaryNeedString)
        {
            case "WOOD":
                GatherWood();
                break;

            case "STONE":
                GatherStone();
                break;

            case "WATER":
                GatherWater();
                break;

            case "PROTEIN":
                GatherProtein();
                break;

            default:
                Debug.Log("WTF");
                break;
        }

        Debug.Log("Gathering: " + primaryNeedString);
    }

    private void GatherWood()
    {

    }

    private void GatherStone()
    {

    }

    private void GatherWater()
    {

    }

    private void GatherProtein()
    {

    }
}
