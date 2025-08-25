using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public CharacterData Player {  get; private set; }

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

        SetData();
    }

    public void SetData()
    {
        Player = new CharacterData(35, 40, 100, 25, 20000, "�ڵ��� �뿹�� ���� 10��¥�� �Ǵ� �ӽ��Դϴ�.");
    }
}
