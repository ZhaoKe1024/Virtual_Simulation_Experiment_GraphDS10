using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanel : MonoBehaviour
{

    public RawImage charaAImg;
    public RawImage charaBImg;
    public Image contentBg;
    public Text contentTxt;

    public Canvas canvas;

    public void ShowCanvas(bool value) {
        canvas.enabled = value;
    }
    // Start is called before the first frame update
    public void showCharaA(bool value)
    {
        charaAImg.enabled = value;
    }
    public void showCharaB(bool value)
    {
        charaBImg.enabled = value;
    }

    public void showContentBg(bool value)
    {
        contentBg.enabled = value;
    }
    public void showContentText(bool value)
    {
        contentTxt.enabled = value;
    }
    public void SetContentText(string value)
    {
        contentTxt.text = value;
    }
}
