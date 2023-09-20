using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject invenSlot;
    public GameObject scrollViewContent;

    [SerializeField] private TextMeshProUGUI itemTotalCountTxt;

    Dictionary<int, string> inventorySlot_ItemName = new Dictionary<int, string>();

    void Awake()
    {
        InstanciateItemSlot();
        DisplayInvenInfo();
    }

    void InstanciateItemSlot()
    {
        for (int i = 0; i < 42; i++)
        {
            invenSlot = Instantiate(invenSlot, scrollViewContent.transform);
            inventorySlot_ItemName.Add(i, null);
        }
    }

    void DisplayInvenInfo()
    {
        itemTotalCountTxt.text = " / " + inventorySlot_ItemName.Count.ToString();
    }
}
