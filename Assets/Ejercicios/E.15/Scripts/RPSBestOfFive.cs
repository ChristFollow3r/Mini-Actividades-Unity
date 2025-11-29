using UnityEngine;

public class RPSBestOfFive : MonoBehaviour
{
    void Start()
    {
        int num1 = Random.Range(1, 4);
        int num2 = Random.Range(1, 4);
        int num1Counter = 0;
        int num2Counter = 0;

        while (num1Counter != 5 || num2Counter != 5)
        {
            if (num1 == num2)
            {
                Debug.Log("It's a tie.");
            }

            if (num1 == 1 && num2 == 2)
            {
                Debug.Log("Console 2 wins this round.");
                num2Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }

            if (num1 == 1 && num2 == 3)
            {
                Debug.Log("Console 1 wins this round.");
                num1Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }

            if (num1 == 2 && num2 == 1)
            {
                Debug.Log("Console 1 wins this round.");
                num1Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }

            if (num1 == 2 && num2 == 3)
            {
                Debug.Log("Console 2 wins this round.");
                num2Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }

            if (num1 == 3 && num2 == 1)
            {
                Debug.Log("Console 2 wins this round.");
                num2Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }

            if (num1 == 3 && num2 == 2)
            {
                Debug.Log("Console 1 wins this round.");
                num1Counter++;
                Debug.Log("Console 1 points: " + num1Counter);
                Debug.Log("Console 2 points: " + num2Counter);
            }
        }


        void Update()
        {

        }
    }
}
