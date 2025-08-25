using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIInventory inventory;
    [SerializeField] private UIStatus status;

    public UIMainMenu MainMenu { get { return mainMenu; } set { mainMenu = value; } }
    public UIInventory Inventory { get { return inventory; } set { inventory = value; } }
    public UIStatus Status { get { return status; } set { status = value; } }

    public static UIManager Instance { get; private set; }

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
    }

    private void Start()
    {
        OpenMainMenuUI();
    }

    public void OpenMainMenuUI()
    {
        Inventory.gameObject.SetActive(false);
        Status.gameObject.SetActive(false);

        MainMenu.statusButton.gameObject.SetActive(true);
        MainMenu.inventoryButton.gameObject.SetActive(true);
    }

    public void OpenStatusUI()
    {
        MainMenu.statusButton.gameObject.SetActive(false);
        MainMenu.inventoryButton.gameObject.SetActive(false);

        Status.gameObject.SetActive(true);
    }

    public void OpenInventoryUI()
    {
        MainMenu.statusButton.gameObject.SetActive(false);
        MainMenu.inventoryButton.gameObject.SetActive(false);

        Inventory.gameObject.SetActive(true);
    }

}
