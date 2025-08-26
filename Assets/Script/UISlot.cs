using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour     //슬롯을 관리 해 줄 클래스 입니다.
{
    [SerializeField] private Button button;         //슬롯에 달려있는 버튼 캐싱
    [SerializeField] private Image equipImage;      //착용/해제 이미지
    
    private ItemData itemData;
    private bool isEquip;

    private void Awake()
    {
        button.onClick.AddListener(EquipOrUnEquip);     //버튼에 메서드 구독
        button.onClick.AddListener(TestReadInfo);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(TestReadInfo);    //구독해제
        button.onClick.RemoveListener(EquipOrUnEquip);
    }

    public void SetItem(ItemData data)      //슬롯에 아이템(정보)을 추가 하는 메서드
    {   
        itemData = data;
    }

    private void RefreshUI()    //아이템 삭제 할 때 쓸 메서드 인것 같아서 슬롯을 삭제해주었습니다.
    {
        //UI인벤토리 내에 리스트에서 지워주는 작업도 필요해 보입니다.
        Destroy(gameObject);
    }

    private void EquipOrUnEquip()   //버튼 이벤트에 등록 할 메서드 토글 형식으로 착용/해제를 처리해 줍니다.
    {
        if (!isEquip)
        {
            isEquip = !isEquip;
            equipImage.gameObject.SetActive(true);
            GameManager.Instance.Player.Equip(itemData);
        }
        else if (isEquip)
        {
            isEquip = !isEquip;
            equipImage.gameObject.SetActive(false);
            GameManager.Instance.Player.UnEquip(itemData);
        }
    }

    private void TestReadInfo()     //테스트용입니다.
    {
        Debug.Log(itemData.Type.ToString() + isEquip.ToString());
    }
}
