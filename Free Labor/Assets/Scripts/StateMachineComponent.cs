using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachineComponent : StateMachineBehaviour
{
    [SerializeField] private string StateName;
    private UnitController Unit;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!Unit)
        {
            Unit = animator.gameObject.GetComponent<UnitController>();
        }

        Unit.SetCurrentState(StateName);
    }

}
