using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co_KingCharacter : MonoBehaviour
{
    public PlayerData co_KingData;

    void Awake()
    {
        co_KingData = new PlayerData("Co_King", 8, 138, "�ڵ��� ���Դϴ�.\n���������� �ڵ��� �� ������ �� ���׿�...", "�ڵ��� ��", 21, 40, 150, 25f, 19654);

    }
}