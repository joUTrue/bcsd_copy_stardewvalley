using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    public static int currentItem = 1;

    [SerializeField]
    private Transform slotParent;
    [SerializeField]
    private Slot[] slots;

    private void OnValidate()
    {
        slots = slotParent.GetComponentsInChildren<Slot>();
    }

    void Awake()
    {
        FreshSlot();
    }

    private void Update()
    {
        ChangeItem();
    }

    public void FreshSlot()
    {
        int i = 0;
        for (; i < items.Count && i < slots.Length; i++)
        {
            slots[i].item = items[i];
        }
        for (; i < slots.Length; i++)
        {
            slots[i].item = null;
        }
    }

    public void AddItem(Item _item)
    {
        if (items.Count < slots.Length)
        {
            items.Add(_item);
            FreshSlot();
        }
        else
        {
            print("½½·ÔÀÌ °¡µæ Â÷ ÀÖ½À´Ï´Ù.");
        }
    }

    public void RemoveItem(Item _item)
    {

    }

    public void Clear()
    {

    }

    public void ChangeItem()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentItem = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentItem = 2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentItem = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            currentItem = 4;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            currentItem = 5;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            currentItem = 6;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            currentItem = 7;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            currentItem = 8;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            currentItem = 9;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            currentItem = 0;
        }
    }
}