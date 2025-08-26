using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour    //게임매니저입니다.
{
    public static GameManager Instance;

    public CharacterData Player { get; private set; }
    public ItemData AttackItem { get; private set; }
    public ItemData DefenseItem { get; private set; }
    public ItemData HealthItem { get; private set; }
    public ItemData CriticalItem { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        SetData();
    }

    public void SetData()   //데이터를 초기화 해주는 메서드 입니다. 유니티 내에서 생성자로 생성하는게 익숙 하지 않아 조금 어려웠습니다.
    {
        AttackItem = new ItemData(ItemType.Attack, 10, false);
        DefenseItem = new ItemData(ItemType.Defense, 10, false);
        HealthItem = new ItemData(ItemType.Health, 10, false);
        CriticalItem = new ItemData(ItemType.Critical, 10, false);
        List<ItemData> Inventory = new List<ItemData>() { AttackItem, DefenseItem, HealthItem, CriticalItem};
        Player = new CharacterData(35, 40, 100, 25, 20000, "코딩의 노예가 된지 10년짜리 되는 머슴입니다.", Inventory);
    }
}
