using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class WenChuanManager : MonoBehaviour
{
    public GameObject WenChuan1,WenChuan2,WenChuan3,WenChuan4;
    public Button button;
    public Text text;

    public int counter=0;

    public float angel1 = 0.0f;
    public float angel2 = 0.0f;

    public GameObject virus1;
    public GameObject virus2;
    public GameObject virus3;
    public GameObject virus4;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        Debug.Log("click");
        
        if (counter == 0)
        {
            WenChuan2.SetActive(true);
            WenChuan1.SetActive(false);
            text.text = "汶川在全国人民的帮助下，一步步的重建...";
        }
        if (counter == 1)
        {
            WenChuan2.SetActive(false);
            WenChuan3.SetActive(true);
            text.text = "汶川在重建之后有了新的面貌！";
        }
        if (counter == 2)
        {
            WenChuan3.SetActive(false);
            WenChuan4.SetActive(true);
            text.text = "12年后，2020年，一场来势汹汹的疫情席卷了全国。" +
                "“昨天你帮我，今天我帮你”，汶川向全国12个城市主动捐赠数百吨蔬菜！以出一份绵薄之力" +
                "你作为新时代青年，选择成为运输车车队的一名志愿者，为国家出一份力！";
        }
        if(counter == 3)
        {
            SceneManager.LoadScene("Scenes/1_2Scene");
        }
        counter++;
    }

        // Update is called once per frame
        void Update()
    {
        if ((null != virus1) || (null != virus3))
        {
            angel1 += 30.0f * Time.deltaTime;
            virus1.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -angel1);
            virus3.transform.rotation = Quaternion.Euler(0.0f, 0.0f, -angel1);


        }

        if ((null != virus2) || (null != virus4))
        {
            angel2 += 20.0f * Time.deltaTime;
            virus2.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angel2);
            virus4.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angel2);

        }
    }
}
