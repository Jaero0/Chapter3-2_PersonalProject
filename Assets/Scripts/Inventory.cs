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

    void IncreaseItemScale() //������ũ�Ⱑ ������ �𸣰� ����...
    {
        for (int i = 0; i < totalItem.Count; i++)
        {
            totalItem[i].transform.localScale = new Vector3(70, 70, 1);
        }
    }

    void InstanciateItem_Slot() //TODO : ������ ��ũ���ϸ� �����۸� �յ� ��
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

    void DisplayInvenInfo() //TODO : ���� ������ ���� ǥ���ϱ�
    {
        itemTotalCountTxt.text = " / " + inventorySlot_ItemName.Count.ToString();
    }
}
