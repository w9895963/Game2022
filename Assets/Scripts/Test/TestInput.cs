using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using UnityEngine;

public class TestInput : MonoBehaviour
{
    private void Awake()
    {
        UnityEngine.InputSystem.PlayerInput comp = gameObject.GetComponent<UnityEngine.InputSystem.PlayerInput>();
        int count = comp.actionEvents.Count;
        UnityEngine.InputSystem.PlayerInput.ActionEvent actionEvent = comp.actionEvents.ToArray().First(
            (act) =>
            {
                string[] vs = act.actionName.Split('[');
                Debug.Log(vs[0]);
                return false;
            });

        Debug.Log(actionEvent.actionName);
        actionEvent.AddListener((d) =>
        {
            var dv = d.ReadValue<float>();
            Debug.Log(dv);
        });
    }

}
