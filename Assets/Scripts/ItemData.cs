using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData
{
    public string itemName {  get; set; }
    public int itemAtt { get; set; }
    public int itemDef { get; set; }
    public string itemInfo { get; set; }

    public ItemData(string Name, string Info, int Att, int Def)
    {
        itemName = Name;
        itemInfo = Info;
        itemAtt = Att;
        itemDef = Def;
    }
}
