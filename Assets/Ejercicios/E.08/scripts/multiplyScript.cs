using UnityEngine;

public class multiplyScript : MonoBehaviour
{
    public float number;

    void Start()
    {

        float[] tableNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Debug.Log(number * tableNumbers[0]);
        Debug.Log(number * tableNumbers[2]);
        Debug.Log(number * tableNumbers[3]);
        Debug.Log(number * tableNumbers[4]);
        Debug.Log(number * tableNumbers[5]);
        Debug.Log(number * tableNumbers[6]);
        Debug.Log(number * tableNumbers[7]);
        Debug.Log(number * tableNumbers[8]);
        Debug.Log(number * tableNumbers[9]);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
