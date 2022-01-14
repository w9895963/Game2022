using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UnityEventTest : MonoBehaviour
{
    private void Start()
    {
        // gameObject.GetComponent<playi>
    }
    public void LogTest(UnityEngine.InputSystem.InputAction.CallbackContext cont)
    {
        Vector2 vector2 = cont.ReadValue<Vector2>();
        Debug.Log(vector2);

    }
}
