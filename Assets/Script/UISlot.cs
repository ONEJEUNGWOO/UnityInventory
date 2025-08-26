using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour     //������ ���� �� �� Ŭ���� �Դϴ�.
{
    [SerializeField] private Button button;         //���Կ� �޷��ִ� ��ư ĳ��
    [SerializeField] private Image equipImage;      //����/���� �̹���
    
    private ItemData itemData;
    private bool isEquip;

    private void Awake()
    {
        button.onClick.AddListener(EquipOrUnEquip);     //��ư�� �޼��� ����
        button.onClick.AddListener(TestReadInfo);
    }

    private void OnDestroy()
    {
        button.onClick.RemoveListener(TestReadInfo);    //��������
        button.onClick.RemoveListener(EquipOrUnEquip);
    }

    public void SetItem(ItemData data)      //���Կ� ������(����)�� �߰� �ϴ� �޼���
    {   
        itemData = data;
    }

    private void RefreshUI()    //������ ���� �� �� �� �޼��� �ΰ� ���Ƽ� ������ �������־����ϴ�.
    {
        //UI�κ��丮 ���� ����Ʈ���� �����ִ� �۾��� �ʿ��� ���Դϴ�.
        Destroy(gameObject);
    }

    private void EquipOrUnEquip()   //��ư �̺�Ʈ�� ��� �� �޼��� ��� �������� ����/������ ó���� �ݴϴ�.
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

    private void TestReadInfo()     //�׽�Ʈ���Դϴ�.
    {
        Debug.Log(itemData.Type.ToString() + isEquip.ToString());
    }
}
