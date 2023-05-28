using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Caroline : NPCControl
{
    private bool firstMeet = true;
    private bool firstMeetDay = true;

    public Sprite _Portrait;

    NPC_Caroline() : base(NPC.Caroline, Item.Stone, Item.Wood)
    {
    }

    public void Awake()
    {
        SetPortrait(_Portrait);
    }
    public override string talkingNPC()
    {
        base.talkingNPC();
        Debug.Log(firstMeet + " " + firstMeetDay);
        if (firstMeet)
        {
            firstMeet = false;
            return "ù����";
        }
        else if (firstMeetDay)
        {
            firstMeetDay = false;
            return "��ħ�λ�";
        }
        Debug.Log(firstMeet + " " + firstMeetDay);
        return "��ȭ1";
    }
}