using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHit : MonoBehaviour
{
    // this is to find the event on another game object


    [SerializeField] private Publisher _publisher;

    private void Start()
    {
        _publisher.CallToFunction += WeMadeThisWork;
    }

    private void WeMadeThisWork(object sender, EventArgs e)
    {
        Debug.Log("This did work on the box.");
    }
}
