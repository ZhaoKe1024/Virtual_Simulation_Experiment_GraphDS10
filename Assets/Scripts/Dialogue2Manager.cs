using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue2Manager : MonoBehaviour
{
    public GameObject inputField;
//    public GameObject linesPanel;
    public GameObject map, image1, image2;
    public GameObject dialogue1, dialogue2,dialogueTeaStu;
    public GameObject buttons;
    public GameObject clock;
    //    public Toggle toggleA, toggleB, toggleC;
    public Text dialogueText;
    public Button mapButton, nextButton,AButton, BButton, CButton, DButton;


    public float angel1 = 0.0f;
    [TextArea(1, 4)] public string[] dialogueLines;
    [SerializeField] private int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
        nextButton.onClick.AddListener(OnClick);
        mapButton.onClick.AddListener(OnShow);
        AButton.onClick.AddListener(OnShow);
        CButton.onClick.AddListener(OnShow);
        DButton.onClick.AddListener(OnShow);
        BButton.onClick.AddListener(OnShow);



    }

    // Update is called once per frame

    void OnShow()
    {
        var button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        if (button.name == "mapButton")
        {
            map.SetActive(true);
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        }
        if ((button.name == "AButton")|| (button.name == "BButton") || (button.name == "CButton"))
        {
            inputField.SetActive(true);
            map.SetActive(false);
            dialogueText.text = "请您分析选择该数据类型的原因，请在上面的文本域里写出您的想法。（写完了请点击下一步）";
        }
        if (button.name == "DButton")
        {
            map.SetActive(false);
            dialogueText.text = "您的想法很棒！";
        }
            
        


        }
    void OnClick()
    {
        if (dialogue2.activeInHierarchy)
        {
            currentLine++;
            
            if (currentLine < dialogueLines.Length)
            {
                dialogueText.text = dialogueLines[currentLine];
                if (currentLine == 1)
                { 
                    
                    buttons.SetActive(true);
                }
                if (currentLine == 2)
                {
                    inputField.SetActive(false);
                    buttons.SetActive(false);

                }
               
                if (currentLine == 3)
                {
                    
                    map.SetActive(true);
                    image1.SetActive(true);
                }
                if (currentLine == 4)
                {
                    image2.SetActive(true);
                }

            }
            else
            {
                dialogue2.SetActive(false);
                dialogueTeaStu.SetActive(true);
                map.SetActive(false);
                mapButton.interactable=false;
            }
            



        }
    }
    void Update()
    {
        if (currentLine == 6)
        {
            var time = 10 - Time.time;

            if (time > 0.0f)
            {
                nextButton.interactable = false;
                clock.SetActive(true);
                angel1 += 50.0f * Time.deltaTime;
                clock.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -angel1);
            }
            else
            {
                nextButton.interactable = true;
                clock.SetActive(false);
            }
        }
        
                   
    }
}