using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum ItemType
{
    Attack,
    Defense,
    Health,
    Critical,
}

public class ItemData
{
    public ItemType Type { get; set; }
    public int Value { get; private set; }
    public bool IsEquip { get; set; }

    public ItemData(ItemType itemType, int value, bool isEquip)
    {
        Type = itemType;
        Value = value;
        IsEquip = isEquip;
    }
}
