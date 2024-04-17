using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TableCreate : MonoBehaviour
{
    public GameObject Row_Prefab;

    private const int MAX_VALUE = 9999;
    private string[] RowKey = { "BJ", "YC", "TY", "JN", "LZ", "XA", "ZZ", "CD", "WH", "HF", "SH", "GY", "FZ" };
    private string[] RowName = { "北京", "银川", "太原", "济南", "兰州", "西安", "郑州", "成都", "武汉", "合肥", "上海", "贵阳", "福州" };
    private int[,] AdjMatrix =
    {
        { MAX_VALUE, 1194,489,422,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE},
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,426,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,650,MAX_VALUE,MAX_VALUE,MAX_VALUE,683,560,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,446,MAX_VALUE,MAX_VALUE,MAX_VALUE,848,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,1128,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,628,MAX_VALUE,MAX_VALUE,783,740,MAX_VALUE,MAX_VALUE,1083,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,586,590,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,637,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,383,MAX_VALUE,MAX_VALUE,MAX_VALUE,872 },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,471,MAX_VALUE,MAX_VALUE,790 },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,1045,MAX_VALUE,MAX_VALUE,MAX_VALUE,1553 },
        {MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE,901,MAX_VALUE,MAX_VALUE,MAX_VALUE,MAX_VALUE},
    };

    private void SetCell(GameObject row, int index, int column)
    {
        if(AdjMatrix[index, column] == MAX_VALUE)
        {
            row.transform.Find(RowKey[column]).GetComponent<Text>().text = "∞";
        }
        else
        {
            row.transform.Find(RowKey[column]).GetComponent<Text>().text = AdjMatrix[index, column] + "";
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 13; i++)
        {
            GameObject table = GameObject.Find("Canvas/AdjMatrix/AdjMatrixPanel/Table");
            GameObject row = GameObject.Instantiate(Row_Prefab, table.transform.position, table.transform.rotation) as GameObject;
            row.name = "row" + (i + 1);
            row.transform.SetParent(table.transform);
            row.transform.localScale = Vector3.one;

            row.transform.Find("RowName").GetComponent<Text>().text = RowName[i];
            for(int j = 0; j < 13; j++)
            {
                SetCell(row, i, j);
            }
            /*
            row.transform.Find("BJ").GetComponent<Text>().text = AdjMatrix[i,0]+"";
            row.transform.Find("YC").GetComponent<Text>().text = AdjMatrix[i, 1] + "";
            row.transform.Find("TY").GetComponent<Text>().text = AdjMatrix[i, 2] + "";
            row.transform.Find("JN").GetComponent<Text>().text = AdjMatrix[i, 3] + "";
            row.transform.Find("LZ").GetComponent<Text>().text = AdjMatrix[i, 4] + "";
            row.transform.Find("XA").GetComponent<Text>().text = AdjMatrix[i, 5] + "";
            row.transform.Find("ZZ").GetComponent<Text>().text = AdjMatrix[i, 6] + "";
            row.transform.Find("CD").GetComponent<Text>().text = AdjMatrix[i, 7] + "";
            row.transform.Find("GY").GetComponent<Text>().text = AdjMatrix[i, 8] + "";
            row.transform.Find("WH").GetComponent<Text>().text = AdjMatrix[i, 9] + "";
            row.transform.Find("SH").GetComponent<Text>().text = AdjMatrix[i, 10] + "";
            row.transform.Find("FZ").GetComponent<Text>().text = AdjMatrix[i,11] + "";
            row.transform.Find("HF").GetComponent<Text>().text = AdjMatrix[i, 12] + "";
            */
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
