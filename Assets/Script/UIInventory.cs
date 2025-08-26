using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour        //�κ��丮UI�� ������ �ִ� Ŭ�����Դϴ�.
{
    [SerializeField] private GameObject uiSlotPrefab;   //�ʿ��� �������� ĳ��/���� ���ݴϴ�
    public GameObject UISlotPrefab { get { return uiSlotPrefab; } set { uiSlotPrefab = value; } }
    private List<UISlot> uISlots = new List<UISlot>();

    public Text itemNumText;
    public RectTransform content; //������ �߰� �� �θ�
    public Button backButton;

    private void Awake()
    {
        Debug.Log("����");
        itemNumText.text = $"Inventory   {GameManager.Instance.Player.Inventory.Count}/120";
        UIManager.Instance.MainMenu.inventoryButton.onClick.AddListener(InventoryUI);
    }

    private void Start()
    {
        backButton.onClick.AddListener(BackToMainMenu);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(BackToMainMenu);
    }

    public void BackToMainMenu()        //�ڷΰ��� ��ư�� ������ �� ����� �޼��� �Դϴ�. �Ŵ������� ������ �Դϴ�.
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void InventoryUI()       //������ ���� ���� �� �ִ� �޼��� �Դϴ�.
    {
        //���� ���� ������ ������ �����ϴٸ� �ϳ� ������ 
        int needCount = GameManager.Instance.Player.Inventory.Count - uISlots.Count; // ���� ĳ���� �κ��丮�� ������ ������ ���� ī��Ʈ�� ���� �ʿ��� ī��Ʈ ���ڸ� ĳ���Ѵ�.

        for (int i = 0; needCount > i; i++)
        {
            Debug.Log($"needcount{needCount} i{i}");
            UISlot slot = Instantiate(UISlotPrefab, content).GetComponent<UISlot>();
            slot.SetItem(GameManager.Instance.Player.Inventory[i]);
            uISlots.Add(slot);
        }
    }
}
