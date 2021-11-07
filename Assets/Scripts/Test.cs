using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;


public class Test : MonoBehaviour

{
    public Text text;

    [DllImport("__Internal")]
    public static extern void GetJSON(string path, string objectName, string callback, string fallback);

    [DllImport("__Internal")]
    public static extern void PostJSON(string path, string value, string objectName, string callback, string fallback);

    private void Start()
    {


        GetJSON(path: "example", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
        
}

    private void OnRequestSuccess(string data)
    {
        text.color = Color.green;
        text.text = data;
    }

    private void OnRequestFailed(string error)
    {
        text.color = Color.red;
        text.text = error;

    }


    private int i = 0;
    private string startTime;

    //private void OnGUI()
    //{
    //    if (GUI.Button(new Rect(10, 10, 100, 100), "Post"))

    //    {
    //        clickTime = System.DateTime.Now.ToString();
    //        PostJSON(path: "user" + i , value: "{\"click\":\"" + clickTime + "\"}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
    //        i += 1;
    //    }
    //}


    public void OnMouseDown()
    {

        startTime = System.DateTime.Now.ToString();
        Debug.Log("test" + startTime);
        PostJSON(path: "user" + i, value: "{\"started\":\"" + startTime + "\"}", gameObject.name, callback: "OnRequestSuccess", fallback: "OnRequestFailed");
        i += 1;

    }

}

