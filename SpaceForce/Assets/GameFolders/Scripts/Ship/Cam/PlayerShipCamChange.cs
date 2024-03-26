using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipCamChange : MonoBehaviour
{
    public static PlayerShipCamChange ShipCam;
    #region [Private] Variables
    private bool CamChange;
    #endregion
    #region [SerializeField] Variables
    [SerializeField] List<GameObject> V_CamObjectList;
    #endregion
    void Start()
    {
        ShipCam = this;
    }

    #region Cam Change Func
    public void F_CamChange()
    {
        CamChange = !CamChange;
        V_CamObjectList[0].SetActive(CamChange);

    }
    #endregion
}
