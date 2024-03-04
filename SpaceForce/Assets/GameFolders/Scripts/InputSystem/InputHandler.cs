using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private InputControl V_InputControl;
    private void OnEnable()
    {
          V_InputControl.Enable();
    }
    private void OnDisable()
    {
        V_InputControl.Disable();
    }
    private void Awake()
    {
        V_InputControl = new InputControl();
    }


  
}
