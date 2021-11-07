using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicks : MonoBehaviour
{
    
    public UserData userData;


    public void OnMouseDown()
    {
        userData.numClicks += 1;
        Debug.Log(userData.numClicks++);

    }
}
