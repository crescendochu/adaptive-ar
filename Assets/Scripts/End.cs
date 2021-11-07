using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class End : MonoBehaviour
{
    public DateTime endTime;
    public UserData userData;

    public void OnMouseDown()
    {
        userData.endTime= System.DateTime.Now;
        Debug.Log(gameObject.name + " " + userData.endTime);

    }
}
