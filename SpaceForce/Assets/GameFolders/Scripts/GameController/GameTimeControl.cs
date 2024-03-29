using UnityEngine;

public class GameTimeControl : MonoBehaviour
{
    [SerializeField] int V_Time;
    void Start()
    {
        F_GameTimeControl(V_Time);
    }

   private void F_GameTimeControl(int Index)
    {
        Time.timeScale = Index;
    }
}
