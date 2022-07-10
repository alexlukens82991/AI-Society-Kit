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
            m_StatesInNeed.Add(new string[2] { StateDictionary.GATHER, diff.ToString()});
        }
        if (SocietyStatus.Instance.SocietyInventory.Stone < SocietyStatus.Instance.SocietyNeeds.Stone)
        {
            diff = SocietyStatus.Instance.SocietyInventory.Stone - SocietyStatus.Instance.SocietyNeeds.Stone;
            m_StatesInNeed.Add(new string[2] { StateDictionary.GATHER, diff.ToString() });
        }
        if (SocietyStatus.Instance.SocietyInventory.Water < SocietyStatus.Instance.SocietyNeeds.Water)
        {
            diff = SocietyStatus.Instance.SocietyInventory.Water - SocietyStatus.Instance.SocietyNeeds.Water;
            m_StatesInNeed.Add(new string[2] { StateDictionary.GATHER, diff.ToString() });
        }

        if (SocietyStatus.Instance.SocietyInventory.RawMeat < SocietyStatus.Instance.SocietyNeeds.RawMeat)
        {
            diff = SocietyStatus.Instance.SocietyInventory.RawMeat - SocietyStatus.Instance.SocietyNeeds.RawMeat;

            m_StatesInNeed.Add(new string[2] { StateDictionary.HUNT, diff.ToString() });
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
                if (float.Parse(state[1]) < float.Parse(mostInNeed[1]))
                {
                    mostInNeed = state;
                }
                else if (float.Parse(state[1]) == float.Parse(mostInNeed[1]))
                {
                    if (Random.value <= 0.5f) // coin flip
                    {
                        mostInNeed = state;
                    }
                }
            }

            targetTrigger = mostInNeed[0];
            animator.SetTrigger(targetTrigger);
            Debug.Log("Setting Trigger: " + targetTrigger);
            return;
        }


        // If there are no needs, SelfCare
        if (m_StatesInNeed.Count == 0)
        {
            animator.SetTrigger(StateDictionary.SELF_CARE);
            Debug.Log("Setting Trigger: " + StateDictionary.SELF_CARE);
            return;
        }
    }
}
