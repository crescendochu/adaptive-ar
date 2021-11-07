using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Start : MonoBehaviour
{
    public DateTime startTime;
    public UserData userData;

    public void OnMouseDown()
    {
        userData.startTime = System.DateTime.Now;
        Debug.Log(gameObject.name + " " + userData.startTime);
    }
}
