using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Part1_1Manager : MonoBehaviour
{
    public GameObject dialogueBox;

    public Text dialogueText, buttonText;
    public Button button;

    [TextArea(1, 4)] public string[] dialogueLines;
    [SerializeField] private int currentLine;

    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
        button.onClick.AddListener(OnClick);
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
                    case 2:
                        buttonText.text = "点击完毕，下一步";
                        break;
                    default:
                        buttonText.text = "下一步";
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
}
