using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MatrixCell : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject MemoryBlock;

    public void OnPointerEnter(PointerEventData eventData)
    {
        MemoryBlock.GetComponent<Text>().color = Color.yellow;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MemoryBlock.GetComponent<Text>().color = Color.black;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
