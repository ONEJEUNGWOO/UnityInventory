using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour    //���ӸŴ����Դϴ�.
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

    public void SetData()   //�����͸� �ʱ�ȭ ���ִ� �޼��� �Դϴ�. ����Ƽ ������ �����ڷ� �����ϴ°� �ͼ� ���� �ʾ� ���� ��������ϴ�.
    {
        AttackItem = new ItemData(ItemType.Attack, 10, false);
        DefenseItem = new ItemData(ItemType.Defense, 10, false);
        HealthItem = new ItemData(ItemType.Health, 10, false);
        CriticalItem = new ItemData(ItemType.Critical, 10, false);
        List<ItemData> Inventory = new List<ItemData>() { AttackItem, DefenseItem, HealthItem, CriticalItem};
        Player = new CharacterData(35, 40, 100, 25, 20000, "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�.", Inventory);
    }
}
