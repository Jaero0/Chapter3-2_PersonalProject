using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBtnScript : MonoBehaviour
{
    public GameObject statusWindowImg;
    
    public void OnClickOpenStatusWindow()
    {
        statusWindowImg.SetActive(true);
    }

    public void OnClickCloseStatusWindow()
    {
        statusWindowImg.SetActive(false);
    }
}
