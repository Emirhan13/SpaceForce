using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotaitonPosition : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }
}