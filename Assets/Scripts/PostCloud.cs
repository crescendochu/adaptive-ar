using System;
using FirebaseWebGL.Examples.Utils;
using FirebaseWebGL.Scripts.FirebaseBridge;
using FirebaseWebGL.Scripts.Objects;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PostCloud : MonoBehaviour
{

    [DllImport("__Internal")]
    public static extern void GetJSON(string path, string objectName, string callback, string fallback);

    [DllImport("__Internal")]
    public static extern void PostJSON(string path, string value, string objectName, string callback, string fallback);

    public TextMeshProUGUI outputText;


    private DateTime _startTime;
    private DateTime _endTime;
    private int _numClicks;
    public string userID;
    //public End end;
    //public Start start;
    public UserData userData;

    public Text text;

    void Start()
    {
        //_numClicks = 0;
        GetJSON(path: "example", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
    }

    
    void Update()
    {
        
    }

    //public void setStartTime(DateTime startTime)
    //{
    //    _startTime = startTime;
    //}

    //public void setEndTime(DateTime endTime)
    //{
    //    _endTime = endTime;
    //}

    //public void onMouseDown()
    //{
    //    _numClicks += 1;
    //}


    //private void OnRequestSuccess(string data)
    //{
    //    text.color = Color.green;
    //    text.text = data;
    //}

    //private void OnRequestFailed(string error)
    //{
    //    text.color = Color.red;
    //    text.text = error;

    //}



    public void postEveryting()
    {
        

       float successRate = 2f / (float)userData.numClicks;
    
       
        TimeSpan  duration = userData.endTime - userData.startTime;
        Debug.Log("Duration:" + duration.TotalSeconds.ToString());
        //PostJSON(path: userID, value: "{\"duration\":\"" + duration.ToString() + "\",\"errorRate\":\"" + successRate + "\"}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");

        FirebaseFirestore.AddDocument("taskPerformance", "{\"duration\":\"" + duration.ToString() + "\",\"errorRate\":\"" + successRate + "\"}", gameObject.name,
             "DisplayData", "DisplayInfo");
    }



    public void DisplayData(string data)
    {
        outputText.color = outputText.color == Color.green ? Color.blue : Color.green;
        outputText.text = data;
        Debug.Log(data);
    }

    public void DisplayInfo(string info)
    {
        outputText.color = Color.white;
        outputText.text = info;
        Debug.Log(info);
    }



    /*
    public void dummyPost()
    {

        startTime = System.DateTime.Now.ToString();
        PostJSON(path: "user" + i, value: "{\"started\":\"" + startTime + "\"}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
        i += 1;

    }*/
}
