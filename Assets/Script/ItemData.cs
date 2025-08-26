using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum ItemType        //Ÿ���� �̳����� ���� �������� �������ͽ� ����ü�� ����� �͵� ��� ������Դϴ�.
{
    Attack,
    Defense,
    Health,
    Critical,
}

public class ItemData       //������(����)�� �����ڸ� ���� ����� �ִ� Ŭ�����Դϴ�.
{
    public ItemType Type { get; set; }
    public int Value { get; private set; }

    public ItemData(ItemType itemType, int value, bool isEquip)
    {
        Type = itemType;
        Value = value;
    }
}
