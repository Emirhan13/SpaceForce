using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public static EnemySpawner EnemySpawnerControl;
    #region [Private] Variables
    #endregion
    #region [SerializeField] Variables
    [SerializeField] int V_EnemyCount;
    [SerializeField] float V_SpawnerTime;
    [SerializeField] List<GameObject> V_EnemyShipList;
    [SerializeField] List<Transform> V_EnemyShipSpawnPointList;

    #endregion
    #region [Public] Variables
    [HideInInspector]
    public int V_CurrentEnemyCount;
    #endregion
    void Start()
    {
        EnemySpawnerControl = this;
        V_CurrentEnemyCount = V_EnemyCount;
        StartCoroutine(F_SpawnerControl());
    }

   
    #region Spawner Funcs
    private IEnumerator F_SpawnerControl()
    {
       
       while (true)
        {
            int V_RandomNumber = Random.Range(0, V_EnemyShipList.Count);
            int V_RandomTransform = Random.Range(0, V_EnemyShipSpawnPointList.Count);
            Instantiate(V_EnemyShipList[V_RandomNumber], V_EnemyShipSpawnPointList[V_RandomTransform].position, Quaternion.Euler(0, -180, 0));
            yield return new WaitForSeconds(V_SpawnerTime);
        }
    }
    #endregion
}
