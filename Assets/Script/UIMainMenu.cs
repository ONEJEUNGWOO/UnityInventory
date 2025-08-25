using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Text goldText;
    public Text levelText;
    public Text idText;
    public Text descriptionText;
    public Button statusButton;
    public Button inventoryButton;

    private void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        SetDescription(GameManager.Instance.Player);
        SetGold(GameManager.Instance.Player);
    }

    private void OnDestroy()
    {
        statusButton.onClick.RemoveListener(OpenStatus);
    }

    public void OpenMainMenu()
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void OpenStatus()
    {
        UIManager.Instance.OpenStatusUI();
    }

    public void OpenInventory()
    {
        UIManager.Instance.OpenInventoryUI();
    }

    public void SetDescription(CharacterData data)
    {
        descriptionText.text = data.Description;
    }

    public void SetGold(CharacterData data)
    {
        goldText.text = data.Gold.ToString("N0");
    }
}
