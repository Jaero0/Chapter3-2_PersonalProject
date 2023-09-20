using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InventoryBtnScripts : MonoBehaviour
{
    public GameObject InventoryWindowImg;
    RectTransform InvenWindowRect;

    void Awake()
    {
        InvenWindowRect = InventoryWindowImg.GetComponent<RectTransform>();
    }

    public void OnClickOpenInvenImg()
    {
        Vector3 invenWindowPos = new Vector3(1260, -220, 0);
        InvenWindowRect.DOAnchorPos(invenWindowPos, 0.5f).SetEase(Ease.OutBack);
    }

    public void OnClickCloseInvenImg()
    {
        Vector3 invenWindowPos = new Vector3(1920, -220, 0);
        InvenWindowRect.DOAnchorPos(invenWindowPos, 0.5f).SetEase(Ease.InBack);
    }
}
