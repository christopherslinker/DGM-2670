using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviour : MonoBehaviour
{

    public UnityEvent startEvent;
    private void Start()
    {
        startEvent.Invoke();
    }
}
