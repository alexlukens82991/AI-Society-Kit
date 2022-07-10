using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckSocietyNeeds : StateMachineComponent
{
    [SerializeField] private List<string[]> m_StatesInNeed = new();

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        string targetTrigger = "";

        m_StatesInNeed.Clear();
        float diff;
        if (SocietyStatus.Instance.SocietyInventory.Wood < SocietyStatus.Instance.SocietyNeeds.Wood)
        {
            diff = SocietyStatus.Instance.SocietyInventory.Wood - SocietyStatus.Instance.SocietyNeeds.Wood;
            m_StatesInNeed.Add(new string[3] { StateDictionary.GATHER, StateDictionary.NEED_GATHER_WOOD.ToString(), diff.ToString()});
        }
        if (SocietyStatus.Instance.SocietyInventory.Stone < SocietyStatus.Instance.SocietyNeeds.Stone)
        {
            diff = SocietyStatus.Instance.SocietyInventory.Stone - SocietyStatus.Instance.SocietyNeeds.Stone;
            m_StatesInNeed.Add(new string[3] { StateDictionary.GATHER, StateDictionary.NEED_GATHER_STONE.ToString(), diff.ToString() });
        }
        if (SocietyStatus.Instance.SocietyInventory.Water < SocietyStatus.Instance.SocietyNeeds.Water)
        {
            diff = SocietyStatus.Instance.SocietyInventory.Water - SocietyStatus.Instance.SocietyNeeds.Water;
            m_StatesInNeed.Add(new string[3] { StateDictionary.GATHER, StateDictionary.NEED_GATHER_WATER.ToString(), diff.ToString() });
        }

        if (SocietyStatus.Instance.SocietyInventory.RawMeat < SocietyStatus.Instance.SocietyNeeds.RawMeat)
        {
            diff = SocietyStatus.Instance.SocietyInventory.RawMeat - SocietyStatus.Instance.SocietyNeeds.RawMeat;

            m_StatesInNeed.Add(new string[3] { StateDictionary.HUNT, StateDictionary.NEED_GATHER_PROTEIN.ToString(), diff.ToString() });
        }
        if (SocietyStatus.Instance.SocietyInventory.CookedMeat < SocietyStatus.Instance.SocietyNeeds.CookedMeat)
        {
            // TODO: Cooking
        }

        foreach (string[] state in m_StatesInNeed)
        {
            Debug.Log("Found state in need: " + state[0] + " | " + state[1]);
        }

        if (m_StatesInNeed.Count > 0)
        {
            string[] mostInNeed = m_StatesInNeed[0];

            foreach (string[] state in m_StatesInNeed)
            {
                if (float.Parse(state[2]) < float.Parse(mostInNeed[2]))
                {
                    mostInNeed = state;
                }
                else if (float.Parse(state[2]) == float.Parse(mostInNeed[2]))
                {
                    if (Random.value <= 0.5f) // coin flip
                    {
                        mostInNeed = state;
                    }
                }
            }

            targetTrigger = mostInNeed[0];
            animator.SetTrigger(targetTrigger);
            animator.SetInteger("PrimaryNeed", int.Parse(mostInNeed[1]));
            Debug.Log("Setting Trigger: " + targetTrigger);
        }
        // If there are no needs, SelfCare
        else
        {
            animator.SetTrigger(StateDictionary.SELF_CARE);
            animator.SetInteger("PrimaryNeed", StateDictionary.NEED_SELF_CARE);
            Debug.Log("Setting Trigger: " + StateDictionary.SELF_CARE);
        }

    }
}
