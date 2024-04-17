using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Menu2Manager : MonoBehaviour
{
    public Button Button1, Button2, Button3, Button4;
    

    // Start is called before the first frame update
    void Start()
    {
        Button1.onClick.AddListener(part1Click);
        Button2.onClick.AddListener(part2Click);
        Button3.onClick.AddListener(part3Click);
        Button4.onClick.AddListener(part4Click);
    }
    void part1Click()
    {
        Button1.image.color = Color.Lerp(Color.white,Color.gray,0.5f);
    }void part2Click()
    {
        Button2.image.color = Color.Lerp(Color.white, Color.gray, 0.5f);
    }
    void part3Click()
    {
        Button3.image.color = Color.Lerp(Color.white, Color.gray, 0.5f);
    }
    void part4Click()
    {
        Button4.image.color = Color.Lerp(Color.white, Color.gray, 0.5f);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
