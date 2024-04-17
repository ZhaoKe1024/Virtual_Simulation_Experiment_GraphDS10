using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public AvgData data;
    public UIPanel panel;
    
    [SerializeField] private int curLine;

     
    // Start is called before the first frame update
    void Start()
    {
        // Init();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("init...");
            Init(); 
            LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);

            ShowUI();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("update....");
            NextLine();
            if(curLine >= data.contents.Count)
            {
                curLine = data.contents.Count;
                Init();
            }
            LoadContent(data.contents[curLine].dialogText, data.contents[curLine].charaADisplay, data.contents[curLine].charaBDisplay);
            
        }
    }

    private void Init()
    {
        Debug.Log("init ui");
        HideUI();
        curLine = 0;
        panel.SetContentText("");
    }
    void ShowUI()
    {
        /*
        panel.showCharaA(true);
        panel.showCharaB(true);
        panel.showContentBg(true);
        panel.showContentText(true);
        */
        panel.ShowCanvas(true);
    }
    void HideUI()
    {
        /*
        Debug.Log("hide ui");
        panel.showCharaA(false);
        panel.showCharaB(false);
        panel.showContentBg(false);
        panel.showContentText(false);
        */
       panel.ShowCanvas(false);
    }
    void NextLine()
    {
        curLine++;
    }
    void LoadText(string value)
    {
        panel.SetContentText(value);
    }

    void LoadContent(string value, bool charaADisplay, bool charaBDisplay)
    {
        panel.SetContentText(value);
        panel.showCharaA(charaADisplay);
        panel.showCharaB(charaBDisplay);
    }

}

