using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CleaningRobot : MonoBehaviour
{
    #region [Private] Variables
    private NavMeshAgent Agent;
    private int TargetIndex = 0;
    #endregion
    #region [SerializeField] Variables
    [SerializeField] List<Transform> AgentTargestList;
    [SerializeField] int TargetCount;
    #endregion

    #region Unity Func
    void Start()
    {
        TargetCount = AgentTargestList.Count - 1;
        Agent = GetComponent<NavMeshAgent>();
        Agent.SetDestination(AgentTargestList[TargetIndex].position);
    }
    #endregion
    #region Agent Funcs
    private void F_AgentMoveControl(Transform Target)
    {
        Agent.SetDestination(Target.position);
    }
    #endregion
    #region Triggers
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AgentTarget"))
        {
            if(TargetIndex == TargetCount)
            {
                TargetIndex = 0;
                F_AgentMoveControl(AgentTargestList[TargetIndex]);
            }
            else
            {
                TargetIndex++;
                F_AgentMoveControl(AgentTargestList[TargetIndex]);
            }
        }   
    }
    #endregion
}
