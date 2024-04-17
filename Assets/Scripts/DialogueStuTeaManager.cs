using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueStuTeaManager : MonoBehaviour
{
    public GameObject dialogueStuTea, menu;
    public GameObject stu1, stu2;
    public GameObject tea1, tea2, tea3, tea4;

    public Button button;
    public int counter=1;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        counter++;
        switch (counter)
        {
            case 1: 
                tea1.SetActive(true);
                break;
            case 2:
                stu1.SetActive(true);
                break;
            case 3:
                tea2.SetActive(true);
                break;
            case 4:
                stu2.SetActive(true);
                break;
            case 5:
                tea3.SetActive(true);
                break;
            case 6:
                tea4.SetActive(true);
                tea3.SetActive(false);
                tea2.SetActive(false);
                tea1.SetActive(false);
                stu1.SetActive(false);
                stu2.SetActive(false);
                break;
            default:
                dialogueStuTea.SetActive(false);
                SceneManager.LoadScene("Scenes/Menu");
                break;
        }
    }
}