using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjMatrixCreate : MonoBehaviour
{

    public GameObject Row_Prefab;//表头预设
    private string[] colKeys = { "col0", "col1", "col2", "col3", "col4", "col5", "col6", "col7", "col8" };
    private const int MAX_VALUE = 9999;
    private int tableRowCount = 6;
    private int[,] AdjMatrix =
    {
        { MAX_VALUE, 1194, 489,422,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE},
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,426,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        { MAX_VALUE,650,MAX_VALUE,MAX_VALUE,MAX_VALUE,683,560,MAX_VALUE,MAX_VALUE},
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,446,MAX_VALUE,MAX_VALUE },
        { MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,1128,MAX_VALUE},
        { MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,628,MAX_VALUE,MAX_VALUE,783,740}
    };

    private void SetCells(Transform row, int i, int j)
    {
        if (AdjMatrix[i, j] == MAX_VALUE)
        {
            row.Find(colKeys[j]).GetComponent<Text>().text = "∞";
        }
        else
        {
            row.Find(colKeys[j]).GetComponent<Text>().text = AdjMatrix[i, j] + "";
        }
    }

    private void SetMCells(Transform mrow, string value, int i, int j)
    {
        if (value.Length<4)
        {
            value = "0" + value;
            mrow.Find("RowValues" + i).Find("col" + j).GetComponent<Text>().text = value;
        }
        else
        {
            mrow.Find("RowValues" + i).Find("col" + j).GetComponent<Text>().text = value;
        }
    }

    private char[] RandomSet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

    private string getRandomAddress()
    {
        string result = "0x00";
        for (int i= 0; i < tableRowCount; i++)
        {
            result += RandomSet[UnityEngine.Random.Range(0,16)];
        }
        return result;
    }


    void Start()
    {
        CreateAdjMatrix();
        CreateMemoeyArea();
        StartCoroutine(InputProgram(1.0f));
    }

    private void CreateAdjMatrix()
    {
        GameObject rows = GameObject.Find("Canvas/MatrixPanel/AdjMatrix/Image/Rows");
        for (int i = 0; i < tableRowCount; i++)//添加并修改预设的过程，将创建10行
        {
            //在Table下创建新的预设实例
            //GameObject table = GameObject.Find("Canvas/MatrixPanel/AdjMatrix/Image/Rows");
            //GameObject row = GameObject.Instantiate(Row_Prefab, table.transform.position, table.transform.rotation) as GameObject;
            Transform row = rows.transform.Find("MatrixRow" + i);

            //if (startAddress.Length < 10) startAddress += "0";
            //Debug.Log(startAddress);
            for(int j = 0; j < colKeys.Length; j++)
            {
                SetCells(row, i, j);
            }
        }
    }

    private void CreateMemoeyArea()
    {
        GameObject mrows = GameObject.Find("Canvas/MatrixPanel/MemoryArea/Image/Rows");

        string startAddress = getRandomAddress();
        int step = colKeys.Length * 8;
        for(int i = 0; i < 6; i++)
        {
            Transform mrow = mrows.transform.Find("Row" + i);
            //row.name = "row" + (i + 1);
            //row.transform.SetParent(table.transform);
            //row.transform.localScale = Vector3.one;//设置缩放比例1,1,1，不然默认的比例非常大
            //设置预设实例中的各个子物体的文本内容
            startAddress = string.Format("0x00{0:X}", Convert.ToInt32(startAddress, 16) + step);
            mrow.transform.Find("Text").GetComponent<Text>().text = startAddress;
            for (int j = 0; j < colKeys.Length; j++)
            {
                SetMCells(mrow, string.Format("{0:X}", AdjMatrix[i, j]), i, j);
            }
        }
    }


    public Image AnimeBlock;
    //public Sprite overrideImage;
    IEnumerator InputProgram(float time)
    {
        yield return new WaitForSeconds(time);

        GameObject MemoryBlock = GameObject.Find("Canvas/MatrixPanel/OSMemory/MemoryBlock");
        List<Transform> lst = new List<Transform>();
        foreach (Transform child in MemoryBlock.transform)
        {
            lst.Add(child);
            // Debug.Log(child.name);
        }
        //int index = 0;
        for (int i = 0; i < lst.Count; i++)
        {
            //if (lst[i].name != "TargetMemory")
            //{
                Destroy(lst[i].gameObject);
            //}
            //else
            //{
            //    index = i;
            //}
        }
        // lst[index].localScale = new Vector3(860, 0, 441);
        //Image go = lst[index].GetComponent<Image>();
        //Debug.Log(go.name);
        //go.overrideSprite = overrideImage;

        // lst[index].localScale = new Vector3(860, 0, 441);
        //lst[index].transform.localScale = new Vector3(4, 2, 0);
        AnimeBlock.GetComponent<MemoryBlockClear>().Clear();

    }

    
}
