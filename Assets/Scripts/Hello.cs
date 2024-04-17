using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{

    public Sprite sprite0;

    public Sprite sprite1;

    public int index = 0;//表示显示第一张图片

    //脚本组件实例化时被调用 当脚本被禁用时此方法还会被调用 因为脚本还是被实例化了
    //最先执行
    private void Awake()
    {

    }

    //当脚本被启用时调用 当脚本被禁用时此方法就不被调用
    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    //初始化 如果脚本被禁用那就不调用此方法
    void Start()
    {   
        Application.targetFrameRate = 50;
        //Debug.Log("hello hello hello!!!!");
        
        //SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        //renderer.flipY = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DoChange();
        }

        //Debug.Log("In Update()..." + Time.deltaTime);

        //float step = 0.8f * Time.deltaTime;
        //相对移动位置
        //this.transform.Translate(0, step, 0);

        //0代表左键 1代表右键 获取此次鼠标点击位置
        //if ( Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("鼠标按下，pos=" + Input.mousePosition);
        //}

        //if (Input.GetMouseButtonUp(0))
        //{
        //    Debug.Log("鼠标抬起，pos=" + Input.mousePosition);
        //}

        //把屏幕坐标变成世界坐标
        //if (Input.GetMouseButton(0))
        //{
        //    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    pos.z = 0;//Z坐标位置为0
        //    Debug.Log("世界坐标：" + pos);
            
        //}
    }

    void DoChange()
    {
        //取出图片渲染器
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        if (index ==0)
        {
            renderer.sprite = this.sprite1;
            index = 1;
        }
        else
        {
            index = 0;
            renderer.sprite = this.sprite0;
        }
    }

    
}
