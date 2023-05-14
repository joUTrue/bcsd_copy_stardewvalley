using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Caroline : NPCControl
{
    private bool firstMeet = true;
    private bool firstMeetDay = true;

    public Sprite Portrait;

    NPC_Caroline() : base(NPC.Caroline, Item.Stone, Item.Wood, null)
    {

    }
    public override string talkingNPC()
    {
        base.talkingNPC();
        Debug.Log(firstMeet + " " + firstMeetDay);
        if (firstMeet)
        {
            firstMeet = false;
            return "첫조우";
        }
        else if (firstMeetDay)
        {
            firstMeetDay = false;
            return "아침인사";
        }
        Debug.Log(firstMeet + " " + firstMeetDay);
        return "대화1";
    }
}
