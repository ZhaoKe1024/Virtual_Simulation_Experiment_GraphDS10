using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1_3Manager : MonoBehaviour
{
    public GameObject dialogueBox;
    //public GameObject teacher;
    //public GameObject doctor;
    //public GameObject transport;
    //public GameObject toggleGroup;
    //public GameObject imageABC, image1, image2, image3;
    public GameObject Email,warning,littleMap,mapGroup;
    //public GameObject inputField;
    //public GameObject clock;
    //public Toggle toggleA, toggleB, toggleC;
    public GameObject pointers;
    //public GameObject linesPanel;
    //public GameObject list1,list2,LinjieList1,LinjieList2;
    //public GameObject warnText;

    public Text dialogueText;
    public Button button, pointerButton,EmailButton;

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
        EmailButton.onClick.AddListener(OnRead);

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

                switch (currentLine)
                {
                    case 3:
                        littleMap.SetActive(true);
                        break;
                    case 4:
                        littleMap.SetActive(false);
                        mapGroup.SetActive(true);
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

    void OnRead()
    {
        if (Email.activeInHierarchy == true)
        {
            Email.SetActive(false);
            warning.SetActive(true);
        }
        else
        {
            Email.SetActive(true);
            warning.SetActive(false);
        }
            
    }
}
