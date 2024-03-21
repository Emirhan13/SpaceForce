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
    [SerializeField] GameObject V_ShipDestroyEffect;
    [SerializeField] List<GameObject> V_ShipDamageEffecOjectList; // 0 - 70 // 1- 50 
    [SerializeField] List<AudioClip> V_ShipDamageClipList;
    [SerializeField] AudioSource V_ShipSource;
    #endregion
    #region [Private] Variables
    #endregion

    #endregion


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            F_ShipDamage(30);
        }
    }
    #region Health Funcs
    public void Interaction(float Damage)
    {
        F_ShipDamage(Damage);
    }
    private void F_ShipDamage (float Damage)
    {
        V_ShipHealth -= Damage;
        StartCoroutine(F_ShipDestroy());
        F_ShipDamageEffectControl();
    }
    private IEnumerator F_ShipDestroy()
    {
        if (V_ShipHealth <= 0)
        {
            V_ShipDestroyEffect.SetActive(true);
            F_ShipSourceControl(0);
            yield return new WaitForSeconds(3f);
            Destroy(gameObject);
        }
    }
    private void F_ShipDamageEffectControl()
    {
        switch (V_ShipHealth)
        {
            case 100:
                foreach (var item in V_ShipDamageEffecOjectList)
                {
                    item.SetActive(false);
                }
                break;
            case 70:
                V_ShipDamageEffecOjectList[0].SetActive(true);
                F_ShipSourceControl(0);
                break;
            case 40:
                V_ShipDamageEffecOjectList[1].SetActive(true);
                F_ShipSourceControl(0);
                break;
            default:
                break;
        }
    }

    private void F_ShipSourceControl(int ClipIndex)
    {
        V_ShipSource.PlayOneShot(V_ShipDamageClipList[ClipIndex]);
    }

    #endregion
}
