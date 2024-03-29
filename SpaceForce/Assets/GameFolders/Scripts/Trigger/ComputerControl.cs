using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerControl : MonoBehaviour
{
    #region [SerializeField] Variables
    [SerializeField] List<GameObject> V_ComputerObjectList;  // 0- ShipCam / 1- Astronaut / 2- PlayerCam
    #endregion
    private bool IsCam = true;

    public void F_CamExitButton()
    {
      StartCoroutine(F_CamExitTime());
    }
   private IEnumerator F_CamExitTime()
   {
        yield return new WaitForSeconds(1f);
        V_ComputerObjectList[0].SetActive(false);
        V_ComputerObjectList[1].SetActive(false);
        V_ComputerObjectList[2].SetActive(true);
        yield return new WaitForSeconds(2f);
        IsCam = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && IsCam)
        {
            V_ComputerObjectList[0].SetActive(true);
            V_ComputerObjectList[1].SetActive(true);
            V_ComputerObjectList[2].SetActive(false);
            IsCam = false;
        }
    }

}
