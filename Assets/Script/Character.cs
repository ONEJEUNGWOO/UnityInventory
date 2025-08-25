using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData
{
    public int Attack { get; private set; }
    public int Defense { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    public CharacterData(int attack, int defense, int health, int critical)
    {
        Attack = attack;
        Defense = defense;
        Health = health;
        Critical = critical;
    }
}

public class Character : MonoBehaviour
{
    
}
