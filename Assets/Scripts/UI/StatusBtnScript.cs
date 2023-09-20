using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StatusBtnScript : MonoBehaviour
{
    public GameObject statusWindowImg;
    RectTransform statusWindowRect;

    void Awake()
    {
        statusWindowRect = statusWindowImg.GetComponent<RectTransform>();
    }

    public void OnClickOpenStatusWindow()
    {
        Vector3 statusWindowPos = new Vector3(1260, -270, 0);
        statusWindowRect.DOAnchorPos(statusWindowPos, 0.2f).SetEase(Ease.OutBack);
    }

    public void OnClickCloseStatusWindow()
    {
        Vector3 statusWindowPos = new Vector3(1920, -270, 0);
        statusWindowRect.DOAnchorPos(statusWindowPos, 0.5f).SetEase(Ease.InBack);
    }
}
