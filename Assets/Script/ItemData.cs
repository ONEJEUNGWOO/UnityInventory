using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum ItemType        //타입을 이넘으로 관리 중이지만 스테이터스 구조체로 만드는 것도 어떨지 고민중입니다.
{
    Attack,
    Defense,
    Health,
    Critical,
}

public class ItemData       //아이템(정보)을 생성자를 통해 만들어 주는 클래스입니다.
{
    public ItemType Type { get; set; }
    public int Value { get; private set; }

    public ItemData(ItemType itemType, int value, bool isEquip)
    {
        Type = itemType;
        Value = value;
    }
}
