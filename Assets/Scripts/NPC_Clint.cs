using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Clint : NPCControl
{
    private bool firstMeet = true;
    private bool firstMeetDay = true;

    public Sprite Portrait;

    NPC_Clint ( ):base(NPC.Clint,Item.Coliflower, Item.Flower, null)
    {

    }
    public override string talkingNPC()
    {
        base.talkingNPC();
        Debug.Log(firstMeet + " " + firstMeetDay);
        if (firstMeet )
        {
            firstMeet = false;
            return "ù����";
        }
        else if (firstMeetDay )
        {
            firstMeetDay = false;
            return "��ħ�λ�";
        }
        Debug.Log(firstMeet +" "+firstMeetDay);
        return "��ȭ1";
    }
}
