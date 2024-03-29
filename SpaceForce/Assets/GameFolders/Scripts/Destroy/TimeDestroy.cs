using UnityEngine;

public class TimeDestroy : MonoBehaviour
{
    [SerializeField] float V_Time;
    [SerializeField] bool V_TriggerDestroy;

    private void Start()
    {  
        if (!V_TriggerDestroy)
        Destroy(gameObject, V_Time);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (V_TriggerDestroy)
            Destroy(other.gameObject);
    }
}
