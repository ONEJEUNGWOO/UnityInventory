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
        Player = new CharacterData(35, 40, 100, 25, 20000, "코딩의 노예가 된지 10년짜리 되는 머슴입니다.");
    }
}
