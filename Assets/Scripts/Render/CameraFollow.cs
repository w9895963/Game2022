using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector2 offset = new Vector2(0, 4);



    private void LateUpdate()
    {

        gameObject.SetPositionLo(target.GetPosition2d().Add(offset));
    }
}
