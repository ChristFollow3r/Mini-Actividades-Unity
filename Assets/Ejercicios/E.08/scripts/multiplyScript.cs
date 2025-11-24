using UnityEngine;

public class multiplyScript : MonoBehaviour
{
    public float number;

    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            Debug.Log(number * (i + 1));
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
