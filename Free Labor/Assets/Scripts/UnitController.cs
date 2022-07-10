using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public string CurrentState;

    public void SetCurrentState(string state)
    {
        CurrentState = state;
    }
}
