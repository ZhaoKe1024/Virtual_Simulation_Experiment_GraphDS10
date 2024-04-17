using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class City : MonoBehaviour //,IPointerDownHandler
{
    //public Text text;
    public LineRenderer lineRenderer;
    public Vector3 v1;
    public Vector3[] v2;
    int number = 0;   //计数出度个数
    //new string name;
    //private void Awake()
    //{
    //    name = transform.name;
    //}
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.positionCount = 2;
        //获取自身LineRenderer组件
        lineRenderer = GetComponent<LineRenderer>();

        //设置宽度
        //line.SetWidth(1, 2);
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.5f;
        //设置颜色
        lineRenderer.startColor = Color.blue;
        lineRenderer.endColor = Color.red;

    }

    // Update is called once per frame
    Transform trans;
    int i = 0;
    bool flag = false;
    float num = 0;
    void Update()
    {
       
        if (num > 50)
        {
            transform.name = Time.time + "";
            //flag = false;
        }
        //Debug.Log(flag);
        if (Input.GetMouseButtonDown(0) && i == 0)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 pos1 = transform.position;
            pos.z = 0;
            float dis = (pos1 - pos).magnitude;
            //Debug.Log(dis);
            if (dis <= 0.5 && i == 0)
            {
                Debug.Log("nameDOWN:" + transform.name);
                //trans = transform;
                //Debug.Log(trans.name);
                v1 = transform.position;

                if (!flag)
                {
                    transform.name = "ball";
                    flag = true;
                }
              

              

 
                //i++;
                //lineRenderer.SetPosition(0, new Vector3(-6,3,0));
                //lineRenderer.SetPosition(0, GameObject.Find("1").transform.position);
                //lineRenderer.SetPosition(1, GameObject.Find("2").transform.position);
            }
            //Debug.Log("click");
            //Object obj = (Object)trans;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Vector3 ano_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 ano_pos1 = transform.position;
            ano_pos.z = 0;
            float ano_dis = (ano_pos1 - ano_pos).magnitude;
            //Debug.Log(dis);
            if (ano_dis <= 0.5)
            {
                Debug.Log("name" + transform.name);
                v2[number] = transform.position;
                //trans = transform;
                //Debug.Log(trans.name);
                Debug.Log("v1:" + v1);
                Debug.Log("v2:" + v2);

                lineRenderer.SetPosition(0, GameObject.Find("ball").transform.position);
                lineRenderer.SetPosition(1, v2[number]);
                number++;

            }
            //Debug.Log("click");
            //Object obj = (Object)trans;

        }
    }

    //public void OnPointerDown(PointerEventData eventData)
    //{
    //    Debug.Log("鼠标按下");
    //}

}
