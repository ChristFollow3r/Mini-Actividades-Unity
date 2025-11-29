using UnityEngine;

public class NestedForLoops : MonoBehaviour
{
    void Start()
    {
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                Debug.Log(i + " x " + j + " = " + (i * j));
            }
        }

    }

    void Update()
    {

    }
}
