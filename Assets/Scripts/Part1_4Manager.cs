using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1_4Manager : MonoBehaviour
{
    public GameObject dialogueBox;
    public GameObject YouXiangForm, WuXiangForm;
    public GameObject YouXiangJuZhen, WuXiangJuZhen;
    public GameObject YouXiangLieJie, WuXiangLinJie;
    public GameObject pointers;
    public GameObject DingDianList;
    public GameObject LinJieGroup;
    


    public Text dialogueText;
    public Button button, pointerButton;

    //public float angel1 = 0.0f;
    private int flag = 0;

    [TextArea(1, 4)] public string[] dialogueLines;
    [SerializeField] private int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
        button.onClick.AddListener(OnClick);
        pointerButton.onClick.AddListener(OnShow);

    }

    // Update is called once per frame

    void OnClick()
    {
        if (dialogueBox.activeInHierarchy)
        {
            currentLine++;

            if (currentLine < dialogueLines.Length)
            {
                dialogueText.text = dialogueLines[currentLine];

                switch (currentLine) { 
                
                    case 1:
                        YouXiangForm.SetActive(true);
                        break;
                    case 2:
                        YouXiangForm.SetActive(false);
                        WuXiangForm.SetActive(true);
                        break;
                    case 3:
                        WuXiangForm.SetActive(false);
                        YouXiangJuZhen.SetActive(true);
                        break;
                    case 4:
                        YouXiangJuZhen.SetActive(false);
                        WuXiangJuZhen.SetActive(true);
                        break;
                    case 5:
                        WuXiangJuZhen.SetActive(false);
                        DingDianList.SetActive(true);
                        break;
                    case 6:
                        DingDianList.SetActive(false);
                        YouXiangLieJie.SetActive(true);
                        break;
                    //case 7:
                    //    YouXiangLieJie.SetActive(false);
                    //    WuXiangLinJie.SetActive(true);
                    //    break;
                    case 7:
                        YouXiangLieJie.SetActive(false);
                        LinJieGroup.SetActive(true);
                        break;
                    default:
                        break;

                }
            }
            else
            {
                dialogueBox.SetActive(false);
            }



        }
    }
    void Update()
    {

    }

    void OnShow()
    {
        ++flag;
        if (pointers.activeInHierarchy == true)
        {
            pointers.SetActive(false);
        }
        else
        {
            pointers.SetActive(true);
        }
    }

}
