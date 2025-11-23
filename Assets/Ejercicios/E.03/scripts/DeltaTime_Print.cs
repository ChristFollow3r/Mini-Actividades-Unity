using System;
using UnityEngine;

public class DeltaTime_Print : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime);
    }
}
