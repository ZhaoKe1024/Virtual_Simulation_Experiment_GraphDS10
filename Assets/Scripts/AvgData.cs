using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvgData : MonoBehaviour
{
    public List<DialogContent> contents;

    // Start is called before the first frame update
    

}

[System.Serializable]
public class DialogContent{
    public string dialogText;
    public bool charaADisplay;
    public bool charaBDisplay;
}
