using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipHealth : MonoBehaviour, Iinteractionable
{
    #region All Variables
    #region [Public] Variables
    #endregion
    #region [SerializeField]  Variables
    [SerializeField] float V_ShipHealth;
    [SerializeField] List<GameObject> V_ShipEffectObjectsList; // 0 - Destroy effect
    #endregion
    #region [Private] Variables
    #endregion

   #endregion
    
    
    
    #region Health Funcs
    public void Interaction(float Damage)
    {
        F_ShipDamage(Damage);
    }
    private void F_ShipDamage (float Damage)
    {
        V_ShipHealth -= Damage;
        StartCoroutine(F_ShipDestroy());
    }
    private IEnumerator F_ShipDestroy()
    {
        if (V_ShipHealth <= 0)
        {
            V_ShipEffectObjectsList[0].SetActive(true);
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }

    #endregion
}
