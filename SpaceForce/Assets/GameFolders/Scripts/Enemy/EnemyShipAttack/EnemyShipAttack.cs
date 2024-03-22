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
    [SerializeField] float V_ShipSpeed;
    
    #endregion


    #region [Private]
    private float V_NextAttack;
    #endregion
    private void Update()
    {
        F_Attack();
        F_ShipMove();
    }

    #region Unity Funcs

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
    private void F_ShipMove()
    {
        transform.Translate(new Vector3(0,0,V_ShipSpeed)*Time.deltaTime);
    }
    #endregion

    //#region Triggers
    //private void OnTriggerStay(Collider other)
    //{
    //    if(other.CompareTag("Player"))
    //    {
    //        F_Attack();
    //    }
    //}
    //#endregion
}
