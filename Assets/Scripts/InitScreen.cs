using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InitScreen : MonoBehaviour
{
    public string message;
    public bool _showInitMessage;
    public Canvas canvas;
    public Button startButton;

    void Start()
    {
        _showInitMessage = true;

    }

    
    void Update()
    {
        
    }



    public void ButtonOnClick()
    {
        canvas.gameObject.SetActive(false);
    }


    
}
