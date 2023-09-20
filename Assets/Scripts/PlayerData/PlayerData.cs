using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    public string name { get; set; }
    public int lv { get; set; }
    public int currentExp { get; set; }
    public float NeedExp { get; set; }
    public string info { get; set; }
    public string nickName { get; set; }
    public int att { get; set; }
    public int def { get; set; }
    public int hp { get; set; }
    public float criticalPercentage { get; set; }
    public int currentGold { get; set; }

    public PlayerData(string Name, int Lv, int CurrentExp, string Info, string NickName, int Att, int Def, int Hp, float CriticalPercentage, int CurrentGold)
    {
        name = Name;
        lv = Lv;
        currentExp = CurrentExp;
        NeedExp = 20;
        info = Info;
        nickName = NickName;
        att = Att;
        def = Def;
        hp = Hp;
        criticalPercentage = CriticalPercentage;
        currentGold = CurrentGold;
    }

    public float SetNeedExp (int lv)
    {
        int temp = 0;
        for (int i = 1; i <= lv; i++)
        {
            temp = 12 * i;
        }

        return NeedExp = 20 * Mathf.Sqrt(lv) + temp;
    }
}