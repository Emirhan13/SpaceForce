using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    public static ScoreControl Score;
    #region [Private] Variables
    private int V_Score;
    #endregion
    #region [[SerializeField] Variables
    [SerializeField] List<TextMeshProUGUI> V_ScoreTextList; // 0- New score / 1- old score
    #endregion

    #region Unity Funcs
    private void Start()
    {
        Score = this;
        
    }
    #endregion



    #region Score Control Func
    public void F_ScoreIncrease(int score)
    {
        V_Score += score;
        V_ScoreTextList[0].text = V_Score.ToString();
        F_ScoreSave();
    }
    #endregion
    #region Score Display Func
    public void F_ScoreDisplayControl()
    {
        V_ScoreTextList[0].text = V_Score.ToString();
        V_ScoreTextList[1].text = PlayerPrefs.GetInt("Score").ToString();
    }
    #endregion
    #region Score Save Funcs
    private void F_ScoreSave()
    {
        PlayerPrefs.SetInt("Score", V_Score);
    }
    #endregion
}
