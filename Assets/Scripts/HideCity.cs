using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //隐藏生成的有向图
    public void SetActive()
    {
        gameObject.SetActive(false);
    }

    public void SetActivePlus()
    {
        gameObject.SetActive(true);
        GameObject.Find("end-Image").SetActive(false);
    }

}
