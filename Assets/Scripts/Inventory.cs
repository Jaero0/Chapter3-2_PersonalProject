using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Inventory : MonoBehaviour
{
    public GameObject invenSlot;
    public GameObject scrollViewContent;

    [SerializeField] List<GameObject> totalItem = new List<GameObject>(); //scriptableObj list ini

    [SerializeField] private TextMeshProUGUI itemTotalCountTxt;

    Dictionary<string, string> inventorySlot_ItemName = new Dictionary<string, string>();

    void Awake()
    {
        IncreaseItemScale();
        InstanciateItem_Slot();
        DisplayInvenInfo();
    }

    void IncreaseItemScale() //아이템크기가 왜인진 모르게 작음...
    {
        for (int i = 0; i < totalItem.Count; i++)
        {
            totalItem[i].transform.localScale = new Vector3(70, 70, 1);
        }
    }

    void InstanciateItem_Slot() //TODO : 아이템 스크롤하면 아이템만 둥둥 뜸
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject slot;
            slot = Instantiate(invenSlot, scrollViewContent.transform);
            if (i < totalItem.Count)
            {
                var items = Instantiate(totalItem[i], slot.transform);
                inventorySlot_ItemName.Add("slot " + i, totalItem[i].name);
            }
            else
            {
                inventorySlot_ItemName.Add("slot " + i, null);
            }
        }

        foreach (KeyValuePair<string, string> item in inventorySlot_ItemName)
        {
            Debug.Log($"({item.Key} : {item.Value})");
        }
    }

    void DisplayInvenInfo() //TODO : 현재 아이템 갯수 표시하기
    {
        itemTotalCountTxt.text = " / " + inventorySlot_ItemName.Count.ToString();
    }
}
