using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Publisher : MonoBehaviour
{

    // This is how you call C# events.
    //Must be public 
    public event EventHandler OnKeyPressed;
    public event EventHandler CallToFunction;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            // Must check to see if it is null and then set parameters. 
            OnKeyPressed?.Invoke(this, EventArgs.Empty);
            CallToFunction?.Invoke(this, EventArgs.Empty);
        }
    }

}
