using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class TriggerTask : MonoBehaviour
{
    public string objectTag;
    public UnityEvent whenTriggered;
    public UnityEvent whenNotTriggered;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
            whenTriggered.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag(objectTag))
        {
            whenNotTriggered.Invoke();
        }
    }
}
