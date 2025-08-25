using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private GameObject uiSlotPrefab;
    public GameObject UISlotPrefab { get { return uiSlotPrefab; } set { uiSlotPrefab = value; } }
    public List<UISlot> uISlots = new List<UISlot>();

    public Text itemNumText;
    public RectTransform content; //������ �߰� �� �θ�
    public Button backButton;

    private int currentNum = 1;

    private void Awake()
    {
        Debug.Log("����");
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

    public void BackToMainMenu()
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void InventoryUI()
    {
        //���� ���� ������ ������ �����ϴٸ� �ϳ� ������ 
        int needCount = currentNum - uISlots.Count; // ���� ĳ���� �κ��丮�� ������ ������ ���� ī��Ʈ�� ���� �ʿ��� ī��Ʈ ���ڸ� ĳ���Ѵ�.

        for (int i = 0; needCount > i; i++)
        {
            Debug.Log($"needcount{needCount} i{i}");
                uISlots.Add(Instantiate(UISlotPrefab, content).GetComponent<UISlot>());
        }
        currentNum++;
    }
}
