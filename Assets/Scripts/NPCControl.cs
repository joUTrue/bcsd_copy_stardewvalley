using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum Item
{
    Flower,
    Stone,
    Wood,
    Coliflower
}
[System.Serializable]
public enum NPC
{
    Clint,
    Caroline
}
public class NPCControl : MonoBehaviour
{
    private NPC npc;
    private int npcLike = 0;
    private Item likeThing;
    private Item hateThing;
    private Sprite portrait;


    public NPCControl(NPC npc, Item likeThing, Item hateThing, Sprite portrait)
    {
        this.npc = npc;
        this.likeThing = likeThing;
        this.hateThing = hateThing;
        this.portrait = portrait;   
    }
    public string GetName()
    {
        return npc.ToString();
    }
    public virtual string talkingNPC()
    {
        return "";
    }

    public Sprite getPortrait()
    {
        return portrait;
    }
}
