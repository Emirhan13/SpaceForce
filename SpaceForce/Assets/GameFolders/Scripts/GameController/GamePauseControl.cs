using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePauseControl : MonoBehaviour
{
    public static GamePauseControl _gamePause;
    [SerializeField] List<GameObject> V_PauseObjectList;
    private bool V_Pause;


    private void Start()
    {
        _gamePause = this;
    }

    #region Pause Funcs
    public void F_PauseControl()
    {
        V_Pause = !V_Pause;
        if(V_Pause)
        {
            Time.timeScale = 0;
            V_PauseObjectList[0].SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            V_PauseObjectList[0].SetActive(false);
        }
    }
    #endregion
}
