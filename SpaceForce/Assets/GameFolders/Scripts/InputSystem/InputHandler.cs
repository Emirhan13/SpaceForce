using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

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
        V_InputControl.Ship.CamChange.performed += F_CamChange;
        V_InputControl.Ship.Fire_1.performed += F_Fire1;
        V_InputControl.Ship.Fire_2.performed += F_Fire2;
        V_InputControl.Ship.ShipBoost.performed += F_ShipBoost;
    }

    private void F_Fire2(InputAction.CallbackContext context)
    {
       if(context.ReadValueAsButton())
        {
            ShipFire._ShipFire.F_ShipFire2Control();
        }
    }

    private void F_Fire1(InputAction.CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            ShipFire._ShipFire.F_ShipFire1Control();
        }
    }

    private void F_CamChange(InputAction.CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
            PlayerShipCamChange.ShipCam.F_CamChange();
        }
    }
    private void F_ShipBoost(InputAction.CallbackContext context)
    {
        if(context.ReadValueAsButton())
        {
           StartCoroutine(Move._MoveControl.F_ShipBoostControl());
        }
    }



    #region Input Control Funcs

    #endregion


}
