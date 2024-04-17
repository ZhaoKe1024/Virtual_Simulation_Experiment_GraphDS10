using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Marker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0;

            float distance = (pos - transform.position).magnitude;
            if (distance < 0.5f)
            {
                Debug.Log("---------------" + gameObject.name);
                Transform weight = transform.Find("Ring");
                weight.gameObject.SetActive(true);
                Debug.Log("==================="+weight.name);
            }

            // SpriteRenderer weight = this.GetComponentInChildren<SpriteRenderer>();
        }

    }
}
