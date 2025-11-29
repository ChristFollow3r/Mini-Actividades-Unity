using UnityEngine;

public class RandomOperation : MonoBehaviour
{

    void Start()
    {
        int num1 = Random.Range(0, 101);
        int num2 = Random.Range(0, 101);
        int operation = Random.Range(0, 5);

        if (operation == 0)
        {
            Debug.Log("Number 1: " + num1);
            Debug.Log("Number 2: " + num2);
            Debug.Log("Adding...");
            Debug.Log((num1 + num2));
        }

        else if (operation == 1)
        {
            Debug.Log("Number 1: " + num1);
            Debug.Log("Number 2: " + num2);
            Debug.Log("Subtracting...");
            Debug.Log((num1 - num2));
        }

        else if (operation == 2)
        {
            Debug.Log("Number 1: " + num1);
            Debug.Log("Number 2: " + num2);
            Debug.Log("Dividing...");
            Debug.Log((num1 / num2));
        }

        else if (operation == 3)
        {
            Debug.Log("Number 1: " + num1);
            Debug.Log("Number 2: " + num2);
            Debug.Log("Multiplying...");
            Debug.Log((num1 * num2));
        }

        else if (operation == 4)
        {
            Debug.Log("Number 1: " + num1);
            Debug.Log("Number 2: " + num2);
            Debug.Log("Modulus...");
            Debug.Log((num1 % num2));
        }
    }

    void Update()
    {

    }
}
