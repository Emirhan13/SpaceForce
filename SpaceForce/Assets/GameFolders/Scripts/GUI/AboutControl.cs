using UnityEngine;

public class AboutControl : MonoBehaviour
{
    #region [SerializeField] Variables
    #endregion
    #region [Private] Variables
    private Animator V_Animator;
    #endregion


    void Start()
    {
        V_Animator = GetComponent<Animator>();
    }


    #region About Funcs
   public void F_CamLeft()
   {
        V_Animator.SetBool("CamMove", true);
   }
   public void F_CamRight()
   {
        V_Animator.SetBool("CamMove", false);
   }
    public void F_CamPassive()
    {
        V_Animator.SetTrigger("CamPassive");
    }
    #endregion
}
