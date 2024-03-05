using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAnimationControl : MonoBehaviour
{
    public static ShipAnimationControl ShipAniControl;
    #region [Public] Veriables
    #endregion
    #region [SerializeField] Veriables
    #endregion
    #region [Private] Veriables
    private Animator V_ShipAnimator;
    #endregion

    private void Awake()
    {
        ShipAniControl = this;
        V_ShipAnimator = GetComponent<Animator>();
    }



    #region Ship Animator Funcs
    public void F_BoolAniControl(string AniName, bool Index)
    {
        V_ShipAnimator.SetBool(AniName, Index);
    }
    public void F_TriggerAniControl(string AniName)
    {
        V_ShipAnimator.SetTrigger(AniName);
    }
    public void F_IntergerAniControl(string AniName, int Index) 
    {
        V_ShipAnimator.SetInteger(AniName, Index);
    }
    public void F_FloatAniControl(string AniName, float Index)
    {
        V_ShipAnimator.SetFloat(AniName, Index);
    }
    #endregion
}
