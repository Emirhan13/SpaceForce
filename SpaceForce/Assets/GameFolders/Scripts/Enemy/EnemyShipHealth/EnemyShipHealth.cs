using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipHealth : MonoBehaviour, Iinteractionable
{
    #region [[SerializeField] Variables
    [SerializeField] float V_ShipHealth;
    [SerializeField] AudioSource V_ShipSource;
    [SerializeField] List<AudioClip> V_ShipClipList;
    [SerializeField] List<GameObject> V_ShipObjectsList; // 0- Destroy effect
    #endregion





    public void Interaction(float Damage)
    {
        F_ShipDamage(Damage);
    }



    #region Ship Health Func
    private void F_ShipDamage(float damage)
    {
        V_ShipHealth -= damage;
        StartCoroutine(F_ShipDestroy());
    }
    private IEnumerator F_ShipDestroy()
    {
        if(V_ShipHealth <= 0)
        {
            V_ShipObjectsList[0].SetActive(true);
            F_ShipSourceControl(0);
            yield return new WaitForSeconds(.5f);
            Destroy(gameObject);
        }
        
    }
    private void F_ShipSourceControl(int ClipIndex)
    {
        V_ShipSource.PlayOneShot(V_ShipClipList[ClipIndex]);
    }
    #endregion
}
