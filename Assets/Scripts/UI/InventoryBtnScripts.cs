using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBtnScripts : MonoBehaviour
{
    public GameObject InventoryWindowImg;

    public void OnClickOpenInvenImg()
    {
        InventoryWindowImg.SetActive(true);
    }

    public void OnClickCloseInvenImg()
    {
        InventoryWindowImg.SetActive(false);
    }
}
