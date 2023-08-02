using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subscirber : MonoBehaviour
{
    
    //  This is to call a function in on the same game object.

    void Start()
    {
        Publisher _publisher = GetComponent<Publisher>();
        _publisher.OnKeyPressed += TestingButtonPress;
    }

    private void TestingButtonPress(object sender, EventArgs e) 
    {
        Debug.Log("This C# event worked");
    }
}
