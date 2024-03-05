using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipFire : MonoBehaviour
{
    #region [Public] Veriables
    public bool V_Attack = true;
    #endregion
    #region [SerializeField] Veriables
    [SerializeField] GameObject V_ShipAttack1Bullet;
    [SerializeField] GameObject V_ShipAttack2Bullet;
    [Tooltip("0-1 Bullet 1 point / 2-3 Bullet 2 point")]
    [SerializeField] List<Transform> V_ShipAttackPointList; // 0 = 1 Attack 1 bullet point / 2-3 Attack 2 bullet point

    #endregion
    void Start()
    {
        
    }

   
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            F_ShipFire1Control();
        }
        if(Input.GetKeyDown (KeyCode.Mouse1))
        {
            F_ShipFire2Control();
        }
    }



    #region Ship Fire Func
    private void F_ShipFire1Control()
    {
        if(V_Attack)
        {
            Instantiate(V_ShipAttack1Bullet, V_ShipAttackPointList[0].position, Quaternion.Euler(90, 0, 0));
            Instantiate(V_ShipAttack1Bullet, V_ShipAttackPointList[1].position, Quaternion.Euler(90, 0, 0));
        }
        
    }
    private void F_ShipFire2Control()
    {
        if (V_Attack)
        {
            Instantiate(V_ShipAttack2Bullet, V_ShipAttackPointList[2].position, Quaternion.Euler(180,0,0));
            Instantiate(V_ShipAttack2Bullet, V_ShipAttackPointList[3].position, Quaternion.Euler(180,0,0));
        }
       
    }
    #endregion
}
