using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour   //�������ͽ�UI�� ���� �ϴ� Ŭ�����Դϴ�.
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

    public void SetSatusText(CharacterData data)        //UI�� ������ ���� �� �ݴϴ�.
    {
        attackText.text = $"���ݷ�\n{data.Attack.ToString()}";
        defenseText.text = $"����\n{data.Defense.ToString()}";
        healthText.text = $"ü��\n{data.Health.ToString()}";
        criticalText.text = $"ġ��Ÿ\n{data.Critical.ToString()}";
    }
}
