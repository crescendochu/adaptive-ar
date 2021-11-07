using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;

public class ClickDetector : MonoBehaviour


{
    private string clickTime;
    private int i = 0;
    void OnMouseDown()
    {
        clickTime = System.DateTime.Now.ToString();
        Debug.Log(i+clickTime);
        i ++ ;
    }
}
