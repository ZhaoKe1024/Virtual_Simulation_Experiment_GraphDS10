using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage2 : MonoBehaviour
{
    //需要改变的图片
    public Sprite Tab3Img;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int i= 2;
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    string path = "Image2/" + i;
        //    Tab3Img = Resources.Load(path, typeof(Sprite)) as Sprite;
        //    gameObject.GetComponent<Image>().sprite = Tab3Img;
        //    i++;
        //}
    }

    public void Im2NextStep()
    {
        
        string path = "Image2/" + i;
        Tab3Img = Resources.Load(path, typeof(Sprite)) as Sprite;
        gameObject.GetComponent<Image>().sprite = Tab3Img;
        i++;
        if (i == 68)
        {
            gameObject.SetActive(false);
        }
    }
    public void Im2ForwordStep()
    {
        
        string path = "Image2/" + i;
        Tab3Img = Resources.Load(path, typeof(Sprite)) as Sprite;
        gameObject.GetComponent<Image>().sprite = Tab3Img;
        i--;
    }
}
