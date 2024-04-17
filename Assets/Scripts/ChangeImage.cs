using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    //被改变的物体
    //public GameObject Tab3;
    //需要改变的图片
     public Sprite Tab3Img;

    //加载将要用于修改的图片的路径
   // public string TabImgPath2 = "C:/Users/sgy/Desktop/实验素材";

    // Start is called before the first frame update
    //void Start()
   // {
        //找到要被改变图片的物体
        //Tab3 = GameObject.Find("Image-code");
        //加载图片
        // Tab3Img = Resources.Load(TabImgPath2, typeof(Sprite)) as Sprite;
        //改变图片
        // Tab3.GetComponent<Image>().sprite = Tab3Img;

        //[SerializeField]
        //Image myImage;

        //[SerializeField]
        //Sprite mySprite;

    // Use this for initialization  

    void Start()

        {

          //Tab3Img = Resources.Load("D:/Codelib/CSharp/firstUnity/dijkstra/Assets/picture/image/g3", typeof(Sprite)) as Sprite;     // Image/pic 在 Assets/Resources/目录下 
            //myImage.sprite = mySprite;
        }
    // }

    // Update is called once per frame
    //void Update()
    //{
    //    Tab3Img = Resources.Load(TabImgPath2, typeof(Sprite)) as Sprite;
    //    //改变图片
    //    Tab3.GetComponent<Image>().sprite = Tab3Img;
    //}
    int i = 1;
    private void Update()
    {
        //D:/ Codelib / CSharp / firstUnity / dijkstra
        
        
        
    }
   public  void ImNextStep()
    {      
        
        string path = "Image/" + i;
        Tab3Img = Resources.Load(path, typeof(Sprite)) as Sprite;
        gameObject.GetComponent<Image>().sprite = Tab3Img;
        i++;
        if (i == 67)
        {
            gameObject.SetActive(false);
        }
    }
    public void ImForwordStep()
    {
        
        string path = "Image/" + i;
        Tab3Img = Resources.Load(path, typeof(Sprite)) as Sprite;
        gameObject.GetComponent<Image>().sprite = Tab3Img;
        i--;
    }
}
