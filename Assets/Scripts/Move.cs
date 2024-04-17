using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public int number = 10;
    public string helloMessage = "hi, walt";
    public float step = 0.02f;
    public bool back = true;


    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = this.gameObject;
        Debug.Log(obj.name + " ");
    }

    // Update is called once per frame
    void Update()
    {
     
        MoveWithMouse();
    }

    void MouseUpDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("左键down点击屏幕位置:" + Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("左键up点击屏幕位置:" + Input.mousePosition);
        }
    }

    //跟随鼠标运动
    void FollowMouse()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            setDirection(pos);

            float step = 0.8f * Time.deltaTime;
            transform.Translate(0, step, 0, Space.Self);
        }
    }

    //设置方向
    void setDirection(Vector3 tar)
    {
        Vector3 head = transform.up;
        Vector3 direction = tar - transform.position;
        float angle = Vector3.SignedAngle(head, direction, transform.forward);
        transform.Rotate(0, 0, angle);
    }

    //鼠标拖动
    //标记是否选中物体开始拖动
    public bool drag = false;
    public void MoveWithMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 postionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            postionMouse.z = 0;
            float distanceBetween = (transform.position - transform.position).magnitude;

            if (distanceBetween < 0.1f)
            {
                drag = true;
            }
            //else
            //{
            //    drag = false;
            //}
        }
        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }
        if (drag)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;
            transform.position = pos;
        }
    }
}
