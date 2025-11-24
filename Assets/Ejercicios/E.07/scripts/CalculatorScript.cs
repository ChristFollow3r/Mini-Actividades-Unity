using UnityEngine;
public enum Operation {Add,Substract,Multiply,Divide,Module};
public class CalculatorScript : MonoBehaviour
{
    public float num1 = 4.5f;
    public float num2 = 5.6f;
    public Operation operation;
  
  

    void Start()
    {
        switch (operation)
        {
            case Operation.Add:
                Debug.Log(num1 + num2);
                break;

            case Operation.Substract:
                Debug.Log(num1 - num2);
                break;

            case Operation.Multiply:
                Debug.Log(num1 * num2);
                break;

            case Operation.Divide:
                Debug.Log(num1 / num2);
                break;

            case Operation.Module:
                Debug.Log(num1 % num2);
                break;

            default:
                Debug.LogError("Noob");
                break;
        }
    }

    void Update()
    {
        
    }
}
