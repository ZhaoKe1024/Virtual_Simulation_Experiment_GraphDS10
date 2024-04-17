using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Part2_1Manager : MonoBehaviour
{
    public Text dialogueText;
    public Button button, pointerButton;
    public GameObject pointers;
    public GameObject dialogueBox;
    public GameObject input;

    public Text Message;

    [TextArea(1, 4)] public string[] dialogueLines;
    [SerializeField] private int currentLine;
    // Start is called before the first frame update
    void Start()
    {
        dialogueText.text = dialogueLines[currentLine];
        button.onClick.AddListener(OnClick);
        currentLine = 0;
    }
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

                    
                    case 1:
                        Debug.Log(input.GetComponent<InputField>().text);
                        if(!input.GetComponent<InputField>().text.Equals("777"))
                        {
                            currentLine--;
                            this.Message.text = "<color=red>填写错误</color>";
                        }
                        else
                        {
                            this.Message.text = "<color=green>填写正确</color>";
                            input.SetActive(false);
                        }
                        break;
                }
            }
            else
            {
                SceneManager.LoadScene("Scenes/DijkstraProof");
                dialogueBox.SetActive(false);
            }
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
