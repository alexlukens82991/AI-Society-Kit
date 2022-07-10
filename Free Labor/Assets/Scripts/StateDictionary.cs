using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StateDictionary
{
    public const string DECISION_PHASE = "DecisionPhase";
    public const string CHECK_SOCIETY_NEEDS = "CheckSocietyNeeds";
    public const string HUNT = "Hunt";
    public const string SELF_CARE = "SelfCare";
    public const string GATHER = "Gather";
    public const string BUILD = "Build";
    public const string DUMP_INVENTORY = "DumpInventory";
    public const string DEBRIEF = "Debrief";

    public const int NEED_SELF_CARE = 0;
    public const int NEED_GATHER_WOOD = 1;
    public const int NEED_GATHER_STONE = 2;
    public const int NEED_EAT_FOOD = 3;
    public const int NEED_DRINK_WATER = 4;
    public const int NEED_GATHER_WATER = 5;
    public const int NEED_GATHER_PROTEIN = 6;

    public static string GetNeed(int needInt)
    {
        switch (needInt)
        {
            case NEED_SELF_CARE:
                return SELF_CARE;

            case NEED_GATHER_WOOD:
                return "WOOD";

            case NEED_GATHER_STONE:
                return "STONE";

            case NEED_EAT_FOOD:
                return "FOOD";

            case NEED_DRINK_WATER:
                return "DRINK_WATER";

            case NEED_GATHER_WATER:
                return "WATER";

            case NEED_GATHER_PROTEIN:
                return "PROTEIN";

            default:
                return null;
        }
    }
}
