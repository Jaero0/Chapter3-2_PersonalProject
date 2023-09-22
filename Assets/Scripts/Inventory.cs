using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    [SerializeField] private GameObject invenSlot;
    [SerializeField] private GameObject scrollViewContent;
    [SerializeField] private GameObject EquipedImg;
    public GameObject EquipedCommitImg;
    [SerializeField] public Button btn;
    [SerializeField] private GameObject InvenCloseBtnImg;

    [SerializeField] List<GameObject> totalItem = new List<GameObject>(); //scriptableObj list ini

    [SerializeField] private TextMeshProUGUI itemTotalCountTxt;
    [SerializeField] private TextMeshProUGUI itemCurrentCountTxt;

    Dictionary<string, string> inventorySlot_ItemName = new Dictionary<string, string>();

    void Awake()
    {
        Instance = this;

        InstanciateItem_Slot();

        DisplayInvenInfo();
    }

    #region create inventorySlot_ItemNameDictionary & item init
    void InstanciateItem_Slot()
    {
        for (int i = 0; i < 30; i++)
        {
            GameObject slot;
            slot = Instantiate(invenSlot, scrollViewContent.transform);
            slot.name = i.ToString();
            if (i < totalItem.Count)
            {
                var items = Instantiate(totalItem[i], slot.transform);
                var equip = Instantiate(EquipedImg, slot.transform);
                inventorySlot_ItemName.Add("slot " + i, totalItem[i].name);
            }
            else
            {
                inventorySlot_ItemName.Add("slot " + i, null);
            }
        }
    }
    #endregion



    #region display max inventory slot count & current item count
    void DisplayInvenInfo()
    {
        itemTotalCountTxt.text = " / " + inventorySlot_ItemName.Count.ToString();

        int itemCurrentount = 0;

        foreach (string value in inventorySlot_ItemName.Values)
        {
            if (value != null)
            {
                itemCurrentount++;
            }
        }

        itemCurrentCountTxt.text = itemCurrentount.ToString();
    }
    #endregion



    #region on click button equip
    public void OnClickEquipItem(Transform tr)
    {
        if (tr.childCount != 0)
        {
            Debug.Log(tr.childCount);
            Debug.Log(EquipedCommitImg);
            Instance.EquipedCommitImg.SetActive(true);
            Instance.InvenCloseBtnImg.SetActive(false);
            Instance.btn.onClick.RemoveAllListeners();
            Instance.btn.onClick.AddListener(() => { OnClickEquipConfirmAdmit(tr); });
        }
    }
    #endregion

    public void OnClickEquipConfirmAdmit(Transform tr) //TODO : Unworkable. Now that you've created an invenslot dynamically, find a way to access it dynamically
    {
        Transform childTransform = tr.GetChild(1);
        GameObject child = childTransform.gameObject;
        child.SetActive(true);
        Instance.EquipedCommitImg.SetActive(false);
        Instance.InvenCloseBtnImg.SetActive(true);
    }

    public void OnClickEquipConfirmCancel() 
    {
        Instance.EquipedCommitImg.SetActive(false);
        Instance.InvenCloseBtnImg.SetActive(true);
    }
}

//if (tr.childCount != 0)
//{
//    Transform childTransform = tr.GetChild(1);
//    GameObject child = childTransform.gameObject;
//    child.SetActive(true);
//}
//else if (tr.childCount == 0)
//{
//    Debug.Log("Empty Slot");
//}
