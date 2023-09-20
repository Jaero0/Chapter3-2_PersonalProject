using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class PlayerStatusDisplay : MonoBehaviour
{
    Co_KingCharacter ck;

    [SerializeField] TextMeshProUGUI nickNameTxt;
    [SerializeField] TextMeshProUGUI nameTxt;
    [SerializeField] TextMeshProUGUI lvTxt;
    [SerializeField] TextMeshProUGUI infoTxt;

    [SerializeField] TextMeshProUGUI currentExpTxt;
    [SerializeField] TextMeshProUGUI maxExpTxt;
    [SerializeField] GameObject expFillImg;
    RectTransform expFillImgRect;

    [SerializeField] TextMeshProUGUI attValueTxt;
    [SerializeField] TextMeshProUGUI defValueTxt;
    [SerializeField] TextMeshProUGUI hpValueTxt;
    [SerializeField] TextMeshProUGUI criticalPercentageValueTxt;
    [SerializeField] TextMeshProUGUI currentGoldValueTxt;

    void Awake()
    {
        expFillImgRect = expFillImg.GetComponent<RectTransform>();
        ck = GetComponent<Co_KingCharacter>(); // 초기화안하면 에러나는이유가..? 스크립트 가지고 있는디...?
    }

    void Start()
    {
        DisplayPlayerInfo(ck.co_KingData);
    }

    #region Display Player Information -> From Name to Current Gold
    void DisplayPlayerInfo(PlayerData pd)
    {
        nickNameTxt.text = pd.nickName;
        nameTxt.text = pd.name;
        lvTxt.text = pd.lv.ToString();
        infoTxt.text = pd.info;
        
        currentExpTxt.text = pd.currentExp.ToString();
        maxExpTxt.text = " / " + (pd.SetNeedExp(pd.lv)).ToString("N2");
        expFillImgRect.sizeDelta = new Vector2((300 / pd.SetNeedExp(pd.lv) * pd.currentExp), 52);
        expFillImgRect.DOScaleX(1, 3f).SetEase(Ease.InExpo);

        attValueTxt.text = pd.att.ToString();
        defValueTxt.text = pd.def.ToString();
        hpValueTxt.text = pd.hp.ToString();
        criticalPercentageValueTxt.text = pd.criticalPercentage.ToString() + "%";
        currentGoldValueTxt.text = pd.currentGold.ToString("N0") + " G";
    }
    #endregion
}
