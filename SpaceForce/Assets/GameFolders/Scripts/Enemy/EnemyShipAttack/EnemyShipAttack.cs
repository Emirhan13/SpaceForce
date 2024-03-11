using System.Collections.Generic;
using UnityEngine;

public class EnemyShipAttack : MonoBehaviour
{
    #region [Public] Variables
    #endregion
    #region [SerializeField] Variables
    [SerializeField] GameObject V_Bullet;
    [SerializeField] List<Transform> V_ShipAttackPointList;
    [SerializeField] float V_AttackRate;
    #endregion


    #region [Private]
    private float V_NextAttack;
    #endregion


    #region Unity Funcs
    private void Start()
    {
        
    }
    private void Update()
    {
        F_Attack();
    }
    #endregion

    #region Attack Funcs
    private void F_Attack()
    {
        if(Time.time > V_NextAttack)
        {
            V_NextAttack = Time.time +1 / V_AttackRate;
            Instantiate(V_Bullet, V_ShipAttackPointList[0].position, Quaternion.Euler(90,0,0));
            Instantiate(V_Bullet, V_ShipAttackPointList[1].position, Quaternion.Euler(90,0,0));
        }
       
    }
    #endregion
}
