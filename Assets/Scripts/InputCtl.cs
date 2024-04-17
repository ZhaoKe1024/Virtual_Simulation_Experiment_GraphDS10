using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputCtl : MonoBehaviour
{
    public InputField inputField;
    //用户输入答案
    public string answer;
    GameObject error;
    private void Awake()
    {
         error = GameObject.Find("error");
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject err = error.transform.Find("error-image").gameObject;
        err.SetActive(false);
        GameObject right = error.transform.Find("right-image").gameObject;
        right.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //匹配用户的输入
        if (inputField.text == "D[V]=G.arcs[v0][v]"||inputField.text== "D[V] = G.arcs[v0][v]" || inputField.text == "D[v]=G.arcs[v0][v]"
            || inputField.text == "D[V]=G.arcs[V0][v]" || inputField.text == "D[V]=G.arcs[v0][V]" || inputField.text == "D[V]=G.arcs[V0][V]"
            || inputField.text == "D[v] =G.arcs[v0][v]" || inputField.text == "D[v]= G.arcs[v0][v]"||inputField.text==answer)
        {
            //解决组件未激活状态下不可以找到问题，使用transform组件
            GameObject button = GameObject.Find("Panel");
            GameObject button1 = button.transform.Find("上一步").gameObject;
            GameObject button2 = button.transform.Find("下一步").gameObject;
            GameObject button3 = button.transform.Find("快进").gameObject;
            GameObject button4 = button.transform.Find("快退").gameObject;
            // 激活进程控制按钮
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            button4.SetActive(true);
            GameObject right = error.transform.Find("right-image").gameObject;
            right.SetActive(true);
            GameObject err = error.transform.Find("error-image").gameObject;
            err.SetActive(false);
        }
        else
        {
            //回答正确or 错误的图标控制
            GameObject err = error.transform.Find("error-image").gameObject;
            err.SetActive(true);

        }
    }
}
