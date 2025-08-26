using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour      //UI매니저 입니다.
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

    public void OpenMainMenuUI()    //UI들을 직접 켰다꺼주며 관리해 줍니다. 매니저에서 만든 메서드를 UI들이 사용하는게 더 좋을 것 같았습니다.
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
