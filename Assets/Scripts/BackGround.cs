using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject myPrefab;
    public Transform parent;

    private void Awake()
    {
        GameObject.Find("程序判断").SetActive(false);
        GameObject.Find("Sim-Canvas").SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        ////设置定点数目
        //lineRenderer.positionCount = 2;
        ////设置宽度
        //lineRenderer.startWidth = 0.2f;
        //lineRenderer.endWidth = 1;
        ////设置颜色
        //lineRenderer.startColor = Color.blue;
        //lineRenderer.endColor = Color.red;
       
    }

    int n = 1;
    int flag = 0;
    public void SetFlag()
    {
        flag = 1;
        //Debug.Log("flag:" + flag);
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            GameObject ball= GameObject.Find("ball");
            ball.name = n+"";
        }

        if (Input.GetKeyDown(KeyCode.N)&&flag==0)
        {
            GameObject ball = Instantiate(myPrefab, parent);
            ball.name =n+ "";
            n++;
            //ball.transform.position = transform.position + new Vector3(0, n++, 0);

            Vector3 postionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            postionMouse.z = 0;
            ball.transform.position = postionMouse;
            //ball.transform.position = Input.mousePosition;
            //Vector3 postionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //ball.transform.position = postionMouse;
            //if (Input.GetMouseButtonUp(0))
            //{
            //    Vector3 postionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //    ball.transform.position = postionMouse;
            //}

        }
        //if (flag == 1&& Input.GetMouseButtonDown(1))
        //{
        //    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector3 pos1 = transform.position;
        //    pos.z = 0;
        //    float dis = (pos1 - pos).magnitude;
        //    Debug.Log(transform.name);
        //    //Debug.Log(dis);
        //    if (dis <= 0.5)
        //    {
        //        //lineRenderer.SetPosition(1,transform.position);
        //        //v1 = transform;
        //        //flag = 2;
        //        Debug.Log(transform.name);
        //    }
        //}
        //if (flag == 2 && Input.GetMouseButtonDown(1))
        //{
        //    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    Vector3 pos1 = transform.position;
        //    pos.z = 0;
        //    float dis = (pos1 - pos).magnitude;
        //    Debug.Log(transform.name);
        //    //Debug.Log(dis);
        //    if (dis <= 0.5)
        //    {
        //        //lineRenderer.SetPosition(2, transform.position);
        //        //v2 = transform;
        //        Debug.Log(transform.name);
        //    }
        //}
    }
}
