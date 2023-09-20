using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]

public class ItemData : ScriptableObject
{
    public string itemName;
    public int itemAtt;
    public int itemDef;
    public string itemInfo;
    public Sprite sprite;
    
    public enum ItemType
    {
        Weapon,
        Armor,
        Accessorie
    }

    public ItemType itemType;
}