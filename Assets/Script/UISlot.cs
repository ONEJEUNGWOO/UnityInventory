using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private Image equipImage;
    private ItemData itemData;
    private bool isEquip;

    private void Awake()
    {
        button.onClick.AddListener(EquipOrUnEquip);
        button.onClick.AddListener(TestReadInfo);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(TestReadInfo);
        button.onClick.RemoveListener(EquipOrUnEquip);
    }

    public void SetItem(ItemData data)
    {   
        itemData = data;
    }

    private void RefreshUI()    //아이템 삭제 할 때 쓸 메서드 인것 같아서 슬롯을 삭제해주었습니다.
    {
        Destroy(gameObject);
    }

    private void EquipOrUnEquip()
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

    private void TestReadInfo()
    {
        Debug.Log(itemData.Type.ToString() + isEquip.ToString());
    }
}
