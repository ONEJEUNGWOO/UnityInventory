using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public Text attackText;
    public Text defenseText;
    public Text healthText;
    public Text criticalText;
    public Button backButton;

    private void Start()
    {
        backButton.onClick.AddListener(BackToMainMenu);
        SetSatusText(GameManager.Instance.Player);
    }

    private void OnDestroy()
    {
        backButton.onClick.RemoveListener(BackToMainMenu);
    }

    public void BackToMainMenu()
    {
        UIManager.Instance.OpenMainMenuUI();
    }

    public void SetSatusText(CharacterData data)
    {
        attackText.text = $"공격력\n{data.Attack.ToString()}";
        defenseText.text = $"방어력\n{data.Defense.ToString()}";
        healthText.text = $"체력\n{data.Health.ToString()}";
        criticalText.text = $"치명타\n{data.Critical.ToString()}";
    }
}
