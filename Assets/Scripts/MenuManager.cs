using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Button part1Button, part2Button, part3Button;

    // Start is called before the first frame update
    void Start()
    {
        part1Button.onClick.AddListener(part1Click);
        part2Button.onClick.AddListener(part2Click);
        part3Button.onClick.AddListener(part3Click);
    }

    void part1Click()
    {
        SceneManager.LoadScene("Scenes/SecondScene");
    }
    void part2Click()
    {
        SceneManager.LoadScene("Scenes/SecondScene");
    }
    void part3Click()
    {
        SceneManager.LoadScene("Scenes/SecondScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
