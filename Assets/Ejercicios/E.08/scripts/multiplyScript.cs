using UnityEngine;

public class multiplyScript : MonoBehaviour
{
    public float number;

    void Start()
    {

        for (int i = 1; i < 11; i++)
        {
            Debug.Log(number * i);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
