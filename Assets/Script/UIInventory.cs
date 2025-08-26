using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour        //인벤토리UI를 관리해 주는 클래스입니다.
{
    [SerializeField] private GameObject uiSlotPrefab;   //필요한 정보들을 캐싱/선언 해줍니다
    public GameObject UISlotPrefab { get { return uiSlotPrefab; } set { uiSlotPrefab = value; } }
    private List<UISlot> uISlots = new List<UISlot>();

    public Text itemNumText;
    public RectTransform content; //슬롯이 추가 될 부모
    public Button backButton;

    private void Awake()
    {
        Debug.Log("구독");
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

    public void BackToMainMenu()        //뒤로가기 버튼을 눌렀을 때 실행될 메서드 입니다. 매니저에서 관리중 입니다.
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void InventoryUI()       //슬롯을 동적 생성 해 주는 메서드 입니다.
    {
        //만약 현재 아이템 슬롯이 부족하다면 하나 만들어라 
        int needCount = GameManager.Instance.Player.Inventory.Count - uISlots.Count; // 현재 캐릭터 인벤토리의 아이템 갯수와 슬롯 카운트를 빼서 필요한 카운트 숫자를 캐싱한다.

        for (int i = 0; needCount > i; i++)
        {
            Debug.Log($"needcount{needCount} i{i}");
            UISlot slot = Instantiate(UISlotPrefab, content).GetComponent<UISlot>();
            slot.SetItem(GameManager.Instance.Player.Inventory[i]);
            uISlots.Add(slot);
        }
    }
}
