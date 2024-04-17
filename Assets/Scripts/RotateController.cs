using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public GameObject CPUModel;

    public int[] direction;

    public void RotateModel()
    {
        this.CPUModel.transform.Rotate(new Vector3(direction[0], direction[1], direction[2]), 45);
    }
}
