using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    // Start is called before the first frame update

    public UnityEvent myUnityEvent;

    private void OnTriggerEnter(Collider other)
    {
        myUnityEvent.Invoke();
    }
}
