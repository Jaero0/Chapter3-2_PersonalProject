using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StatusBtnScript : MonoBehaviour
{
    public GameObject statusWindowImg;
    RectTransform statusWindowRect;

    [SerializeField] GameObject pl;
    Animator animator;
    SpriteRenderer sr;

    void Awake()
    {
        statusWindowRect = statusWindowImg.GetComponent<RectTransform>();
        animator = pl.GetComponent<Animator>();
        sr = pl.GetComponent<SpriteRenderer>();
    }

    public void OnClickOpenStatusWindow()
    {
        Vector3 statusWindowPos = new Vector3(1260, -270, 0);
        statusWindowRect.DOAnchorPos(statusWindowPos, 0.5f).SetEase(Ease.OutBack);
        animator.SetBool("ShouldMove", true);
        Invoke("AnimatorSetFalse", 0.5f);
    }

    public void OnClickCloseStatusWindow()
    {
        Vector3 statusWindowPos = new Vector3(1920, -270, 0);
        statusWindowRect.DOAnchorPos(statusWindowPos, 1f).SetEase(Ease.InBack);
        sr.flipX = true;
        animator.SetBool("ShouldMove", true);
        Invoke("AnimatorSetFalse", 1f);
        Invoke("FlipXSprite", 1f);
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
