using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour
{
    public LineRenderer lr;
    public Transform v0;
    public Transform v1;

    public bool isDirected = true;
    public int weight;

    public int layerOrder;
    // Start is called before the first frame update
    void Start()
    {
        lr.positionCount = (2);
        lr.sortingLayerID = layerOrder;
        // Debug.Log("起点:" + v0.name + "终点:" + v1.name + "权重:" + weight);
        lr.SetPosition(0, v0.position);
        lr.SetPosition(1, v1.position);
        //if (isDirected)
        //{
        Transform weight = transform.Find("pointer");
        weight.gameObject.SetActive(true);
        //}

    }

    // Update is called once per frame
    void Update()
    {
    }
}