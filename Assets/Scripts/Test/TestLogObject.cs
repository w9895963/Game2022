using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLogObject : MonoBehaviour
{
    public Object obj;

    [ContextMenu("Test")]
    public void LogObject()
    {
        Debug.Log(obj);
    }
}
