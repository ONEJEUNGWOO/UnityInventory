using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData
{
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }
    public int Gold { get; private set; }
    public string Description { get; private set; }

    public CharacterData(int attack, int defense, int health, int critical, int gold, string description)
    {
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
        Gold = gold;
        Description = description;
    }
}
