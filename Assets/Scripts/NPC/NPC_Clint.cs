using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Clint : NPCControl
{
    private bool firstMeet = true;
    private bool firstMeetDay = true;

    public Sprite _Portrait;

    NPC_Clint() : base(NPC.Clint)
    {

    }

    public void Awake()
    {
        SetPortrait(_Portrait);
    }
    public override string talkingNPC()
    {
        base.talkingNPC();
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
        return "��ȭ1";
    }
}
