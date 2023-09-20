using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public GameObject invenSlot;
    public GameObject scrollViewContent;

    [SerializeField] private TextMeshProUGUI itemTotalCountTxt;

    Dictionary<GameObject, string> inventorySlot_ItemName = new Dictionary<GameObject, string>();

    void Awake()
    {
        InstanciateItemSlot();
        DisplayInvenInfo();
    }

    void InstanciateItemSlot()
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject slot;
            slot = Instantiate(invenSlot, scrollViewContent.transform);
            inventorySlot_ItemName.Add(slot, null);
        }
    }

    void DisplayInvenInfo()
    {
        itemTotalCountTxt.text = " / " + inventorySlot_ItemName.Count.ToString();
    }
}
