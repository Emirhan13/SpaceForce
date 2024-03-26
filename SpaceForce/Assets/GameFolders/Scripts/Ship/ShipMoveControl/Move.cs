using System.Collections;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static Move _MoveControl;
    #region [Public] Veriables
    public bool V_ShipMove = true;
    #endregion
    #region [SerializeField] Veriables
    [SerializeField] float V_ShipRotationSpeed;
    [SerializeField] float V_ShipMoveSpeed;
    [SerializeField] float V_ShipBoostPower;
    [SerializeField] float V_ShipBoostTime;
    #endregion
    #region [Private] Veriables
    private Rigidbody V_ShipRb;
    private float V_MoventDirection;
    #endregion
    void Start()
    {
        V_ShipRb = GetComponent<Rigidbody>();
        _MoveControl = this;
        
    }

    #region Unity Funcs
    void Update()
    {
        F_ShipRotationControl();
        
        
    }
    #endregion

    #region Ship Move Funcs
    private void F_ShipRotationControl()
    {
        if(V_ShipMove)
        {
            V_MoventDirection = Input.GetAxisRaw("Horizontal");
            V_ShipRb.velocity = new Vector2(V_MoventDirection * V_ShipRotationSpeed, V_ShipRb.velocity.y);
           F_AnimatorControl();
           
            
        }
    }

    public IEnumerator F_ShipBoostControl()
    {
        bool Boost = true;
        if(Boost)
        {
            V_ShipRotationSpeed += V_ShipBoostPower;
            yield return new WaitForSeconds(V_ShipBoostTime);
            Boost = false;
            V_ShipRotationSpeed -= V_ShipBoostPower;
            yield return new WaitForSeconds(5f);
            Boost = true;
        }
    }
   
    private void F_AnimatorControl()
    {
        switch (V_MoventDirection)
        {
            case -1:
                ShipAnimationControl.ShipAniControl.F_IntergerAniControl("Rotation", -1);
                break;
            case 1:
                ShipAnimationControl.ShipAniControl.F_IntergerAniControl("Rotation", 1);
                break;
            case 0:
                ShipAnimationControl.ShipAniControl.F_IntergerAniControl("Rotation", 0);
                break;
            default:
                break;
        }
    }
    #endregion
}
