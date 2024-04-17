using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SimManager : MonoBehaviour
{
    string[] str1 = File.ReadAllLines(@"C:\Users\sgy\Desktop\实验素材\实验语句.txt", Encoding.Unicode);
    public GameObject dialogueBox;
    public Text dialogueText, nameText;
    //快进使用
    int[] array = { 1, 3, 5, 7, 9, 11, 14, 15, 17, 20, 23, 27, 30, 34, 38, 41, 44, 49, 51, 58, 62, 65, 66 };
    int i = 1;

    [TextArea(1, 3)]
    //public string[] dialogueLines;
    [SerializeField] private int currentLine;
    [SerializeField] private int currentLine2;
    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = str1[currentLine];
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    currentLine++;
        //    //if (currentLine < str1.Length)
        //    if(str1[currentLine]!=null)
        //        dialogueText.text = str1[currentLine];
        //    else
        //        dialogueBox.SetActive(false);
        //}

    }

    public void TextNextStep()
    {
        currentLine++;
        //currentLine2 = array[i];
        //if (currentLine < currentLine2)
        //{
        //    currentLine = currentLine2;
        //}
        Debug.Log("currentLine:" + currentLine);
        if (currentLine == 13)
        {
            GameObject root =  GameObject.Find("Sim-Canvas");
            GameObject temp =  root.transform.Find("程序判断").gameObject;
            temp.SetActive(true);
            GameObject childpanel = GameObject.Find("childPanel");
            //childpanel.SetActive(false);
            GameObject button = GameObject.Find("Panel");
            GameObject button1 = button.transform.Find("上一步").gameObject;
            GameObject button2 = button.transform.Find("下一步").gameObject;
            GameObject button3 = button.transform.Find("快进").gameObject;
            GameObject button4 = button.transform.Find("快退").gameObject;
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);

        }
        if (currentLine == 14)
        {
            GameObject root = GameObject.Find("Sim-Canvas");
            GameObject temp = root.transform.Find("程序判断").gameObject;
            temp.SetActive(false);
            GameObject Panel = GameObject.Find("Panel");
            GameObject childpanel = Panel.transform.Find("childPanel").gameObject;
            childpanel.SetActive(true);

        }
        //if (currentLine < str1.Length)
        if (str1[currentLine] != "end")
            dialogueText.text = str1[currentLine];
        else
            dialogueBox.SetActive(false);

        if (currentLine == 66)
        {
            GameObject root = GameObject.Find("Panel");
            GameObject stop = root.transform.Find("end-Image").gameObject;
            stop.SetActive(true);
        }
    }
    public void TextForwordStep()
    {
        currentLine--;
        //if (currentLine < str1.Length)
        if (str1[currentLine] != null)
            dialogueText.text = str1[currentLine];
        else
            dialogueBox.SetActive(false);

    }


    public void TextNextStep2()
    {
        i++;
        currentLine2=array[i];
        if (currentLine2 < currentLine)
        {
            currentLine2 = currentLine;
        }
        Debug.Log("currentLine:" + currentLine);
        if (currentLine == 14)
        {
            GameObject root = GameObject.Find("Sim-Canvas");
            GameObject temp = root.transform.Find("程序判断").gameObject;
            temp.SetActive(true);
            GameObject childpanel = GameObject.Find("childPanel");
            childpanel.SetActive(false);
            GameObject button = GameObject.Find("Panel");
            GameObject button1 = button.transform.Find("上一步").gameObject;
            GameObject button2 = button.transform.Find("下一步").gameObject;
            button1.SetActive(false);
            button2.SetActive(false);

        }
        if (currentLine == 15)
        {
            GameObject root = GameObject.Find("Sim-Canvas");
            GameObject temp = root.transform.Find("程序判断").gameObject;
            temp.SetActive(false);
            GameObject Panel = GameObject.Find("Panel");
            GameObject childpanel = Panel.transform.Find("childPanel").gameObject;
            childpanel.SetActive(true);

        }
        //if (currentLine < str1.Length)
        if (str1[currentLine] != "end")
            dialogueText.text = str1[currentLine];
        else
            dialogueBox.SetActive(false);
    }
    public void TextForwordStep2()
    {
        for (int i = 0; i < array.Length; i++)
        {
            currentLine = array[i];
        }
        //if (currentLine < str1.Length)
        if (str1[currentLine] != null)
            dialogueText.text = str1[currentLine];
        else
            dialogueBox.SetActive(false);

    }
}