using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    public enum ItemCategory
    {
        Tool,
        Material,
        Food
    }
    public string itemName;
    public Sprite itemImage;
    public ItemCategory category;
}
