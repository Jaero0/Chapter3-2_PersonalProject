using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InventoryBtnScripts : MonoBehaviour
{
    public GameObject InventoryWindowImg;
    RectTransform InvenWindowRect;

    [SerializeField] GameObject pl;
    Animator animator;
    SpriteRenderer sr;

    void Awake()
    {
        InvenWindowRect = InventoryWindowImg.GetComponent<RectTransform>();
        animator = pl.GetComponent<Animator>();
        sr = pl.GetComponent<SpriteRenderer>();
    }

    public void OnClickOpenInvenImg()
    {
        Vector3 invenWindowPos = new Vector3(1260, -220, 0);
        InvenWindowRect.DOAnchorPos(invenWindowPos, 0.5f).SetEase(Ease.OutBack);
        sr.flipX = true;
        animator.SetBool("ShouldMove", true);
        Invoke("AnimatorSetFalse", 0.5f);
        Invoke("FlipXSprite", 0.5f);
    }

    public void OnClickCloseInvenImg()
    {
        Vector3 invenWindowPos = new Vector3(1920, -220, 0);
        InvenWindowRect.DOAnchorPos(invenWindowPos, 1f).SetEase(Ease.InBack);
        animator.SetBool("ShouldMove", true);
        Invoke("AnimatorSetFalse", 1f);
    }

    void AnimatorSetFalse()
    {
        animator.SetBool("ShouldMove", false);
    }

    void FlipXSprite()
    {
        sr.flipX = false;
    }
}
