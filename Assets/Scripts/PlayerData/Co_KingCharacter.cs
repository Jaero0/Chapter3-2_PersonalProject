using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co_KingCharacter : MonoBehaviour
{
    public PlayerData co_KingData;

    void Awake()
    {
        co_KingData = new PlayerData("Co_King", 8, 138, "코딩의 왕입니다.\n죽을때까지 코딩만 할 생각인 것 같네요...", "코딩의 왕", 21, 40, 150, 25f, 19654);

    }
}