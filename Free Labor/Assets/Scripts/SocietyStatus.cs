using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SocietyStatus : Singleton<SocietyStatus>
{
    [SerializeField] private SocietyNeedsObject SocietyNeeds;
    [SerializeField] private SocietyInventory SocietyInventory;
}
