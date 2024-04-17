using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1_2Manager : MonoBehaviour
{
    public GameObject dialogueBox;
    //public GameObject teacher;
    //public GameObject doctor;
    //public GameObject transport;
    public GameObject toggleGroup;
    public GameObject imageABC,image1,image2,image3;
    //public GameObject inputField;
    public GameObject clock;
    public Toggle toggleA, toggleB, toggleC;
    public GameObject pointers;
    //public GameObject linesPanel;
    //public GameObject list1,list2,LinjieList1,LinjieList2;
    public GameObject warnText;

    public Text dialogueText,buttonText,labelA,labelB,labelC;
    public Button button,pointerButton;

    public float angel1 = 0.0f;
    private int flag = 0;

    [TextArea(1, 4)] public string[] dialogueLines;
    [SerializeField] private int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
        button.onClick.AddListener(OnClick);
        pointerButton.onClick.AddListener(OnShow);
        
        button.interactable = false;
        

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

                if (flag >= 1)
                {
                    if (currentLine == 2)
                    {
                        
                        image3.SetActive(false);
                    }
                    if (currentLine == 4){
                        image3.SetActive(true);
                        image2.SetActive(false);
                    }
                    if(currentLine == 7)
                    {
                        image3.SetActive(false);
                        warnText.SetActive(true);

                    }                    

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
        if (flag == 1)
        {
            var time = 10 - Time.time;

            if (time > 0.0f)
            {
                pointerButton.interactable = false;
                clock.SetActive(true);
                angel1 += 50.0f * Time.deltaTime;
                clock.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -angel1);
            }
            else
            {
                pointerButton.interactable = true;
                button.interactable = true;
                clock.SetActive(false);
                
            }
        }

        if (currentLine == 1)
        {
            image1.SetActive(true);
        }

        if (currentLine == 8)
        {
            imageABC.SetActive(true);
            image1.SetActive(false);
            toggleGroup.SetActive(true);
            if (toggleA.isOn)
                labelA.color = Color.green;
            else if (toggleB.isOn)
                labelB.color = Color.red;
            else if (toggleC.isOn)
                labelC.color = Color.red;

        }

        if (currentLine == 1000)
        {
            toggleGroup.SetActive(true);
            labelA.text = "a";
            labelB.text = "b";
            labelC.text = "c";
            if (toggleA.isOn)
                labelA.color = Color.red;
            else if (toggleB.isOn)
                labelB.color = Color.red;
            else if (toggleC.isOn)
                labelC.color = Color.green;

            
        }
        //if (currentLine == 18)
        //{
        //    toggleGroup.SetActive(false);
        //    imageABC.SetActive(false);
        //    linesPanel.SetActive(true);
        //    inputField.SetActive(true);
        //}
        //if (currentLine == 19)            
        //    inputField.SetActive(false);
        //if (currentLine == 22)
        //    list1.SetActive(true);
        //if(currentLine == 23)
        //{
        //    list1.SetActive(false);
        //    list2.SetActive(true);
        //}
        //if (currentLine == 25)
        //{
            
        //    list2.SetActive(false);
        //    image1.SetActive(true);
        //}
        //if (currentLine == 27)
        //{
        //    image1.SetActive(false);
        //    image2.SetActive(true);
        //}
        //if (currentLine == 28)
        //{
        //    image2.SetActive(false);
        //    image3.SetActive(true);
        //}
        //if (currentLine == 29)
        //{
        //    image3.SetActive(false);
        //    LinjieList1.SetActive(true);
        //}
        //if (currentLine == 32)
        //{
        //    LinjieList1.SetActive(false);
        //    LinjieList2.SetActive(true);
        //}

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
