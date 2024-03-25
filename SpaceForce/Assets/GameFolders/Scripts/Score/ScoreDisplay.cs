using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private void OnEnable()
    {
        ScoreControl.Score.F_ScoreDisplayControl();
    }
}
