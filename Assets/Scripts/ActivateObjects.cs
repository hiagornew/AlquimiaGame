using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivateObjects : MonoBehaviour
{
    public UnityEvent activateEvent;

    public void Activate()
    {
        activateEvent.Invoke();
    }
}
