using UnityEngine;

public class Move : MonoBehaviour
{
    #region [Public] Veriables
    public bool V_ShipMove = true;
    public bool V_ShipMoveInput;
    #endregion
    #region [SerializeField] Veriables
    [SerializeField] float V_ShipRotationSpeed;
    [SerializeField] float V_ShipMoveSpeed;
    #endregion
    #region [Private] Veriables
    private Rigidbody V_ShipRb;
    private float V_MoventDirection;
    #endregion
    void Start()
    {
        V_ShipRb = GetComponent<Rigidbody>();
        
    }

    #region Unity Funcs
    void Update()
    {
        F_ShipRotationControl();
        F_ShipInputControl();
        F_ShipMoveControl();
        
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
    private void F_ShipMoveControl()
    {
        if(V_ShipMoveInput && V_ShipMove)
        {
            transform.Translate(new Vector3(0, 0, V_ShipMoveSpeed) * Time.deltaTime);
        }
        
    }
    private void F_ShipInputControl()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            V_ShipMoveInput = !V_ShipMoveInput;
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
