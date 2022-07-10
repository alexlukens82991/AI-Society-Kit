using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActionTicket : MonoBehaviour
{
    public abstract void SendTicket();
}
public enum TicketType
{
    WoodTarget,
    StoneTarget,
    WaterSourceTarget,
    ProteinTarget,
    StorageFacilitiyTarget,
    DrinkWaterTarget,
    EatFoodTarget
}
