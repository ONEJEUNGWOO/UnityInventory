using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterData      //캐릭터(정보) 를 관리 하는 클래스 입니다.
{
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    public string Description { get; private set; }

    public List<ItemData> Inventory { get; set; }

    public CharacterData(int attack, int defense, int health, int critical, int gold, string description, List<ItemData> inventory)
    {
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
        Gold = gold;
        Description = description;
        Inventory = inventory;
    }

    public void AddItem(ItemData item)  //인벤토리에 아이템을 넣어주는 메서드 입니다.
    {
        Inventory.Add(item);
    }

    public void Equip(ItemData item)    //현재는 스위치 이지만 enum이 아니라 구조체를 이용하면 swich문을 사용하지 않아도 될 것 같습니다
    {
        switch (item.Type)
        {
            case ItemType.Attack:
                Attack += item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Defense:
                Defense += item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Health:
                Health += item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Critical:
                Critical += item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
        }
    }

    public void UnEquip(ItemData item)  //해제 해주는 메서드 입니다.
    {
        switch (item.Type)
        {
            case ItemType.Attack:
                Attack -= item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Defense:
                Defense -= item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Health:
                Health -= item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
            case ItemType.Critical:
                Critical -= item.Value;
                UIManager.Instance.Status.SetSatusText(this);
                break;
        }
    }
}
