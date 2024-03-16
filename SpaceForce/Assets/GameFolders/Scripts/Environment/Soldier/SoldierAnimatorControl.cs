using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoldierAnimatorControl : MonoBehaviour, IenvironmentInteractionable
{
    #region [Private] Variables
    private Animator V_SoldierAnimator;
    #endregion

    private void Start()
    {
        V_SoldierAnimator = GetComponent<Animator>();
    }






    #region Animator Func
    private void F_SoldierAniControl(string AniName, bool Index)
    {
        V_SoldierAnimator.SetBool(AniName, Index);
    }
    #endregion

    #region Trigger Funcs
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !V_SoldierAnimator.GetCurrentAnimatorStateInfo(0).IsName("Salute"))
        {
            F_SoldierAniControl("Salute", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player") && !V_SoldierAnimator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            F_SoldierAniControl("Salute", false);
        }
    }
    #endregion
}
