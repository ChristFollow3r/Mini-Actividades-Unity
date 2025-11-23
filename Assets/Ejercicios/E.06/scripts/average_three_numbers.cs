using UnityEngine;

public class average_three_numbers : MonoBehaviour
{
    public float num1 = 6.8f;
    public float num2 = 7.3f;
    public float num3 = 9.2f;
    private float noMagicNumbersInMyCode = 3;
    

    void Start()
    {
        Debug.Log((num1 + num2 + num3) / noMagicNumbersInMyCode);
    }

    void Update()
    {
        
    }
}
