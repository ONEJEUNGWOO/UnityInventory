using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterData
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

    public void AddItem(ItemData item)
    {
        Inventory.Add(item);
    }

    public void Equip(ItemData item)
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

    public void UnEquip(ItemData item)
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
