using UnityEngine;

public class RPS : MonoBehaviour
{
    public int userNumber;

    void Start()
    {
        RockPaperScissors();
    }

    void Update()
    {

    }

    void RockPaperScissors()
    {
        int rpsNumber = Random.Range(1, 4); // 1 is rock, 2 is paper, 3 is scissors.
        switch (rpsNumber)
        {
            case 1:
                if (userNumber == 1)
                {
                    Debug.Log("Rock!");
                    Debug.Log("Its a tie.");
                }
                else if (userNumber == 2)
                {
                    Debug.Log("Rock!");
                    Debug.Log("User wins!");
                }
                else if (userNumber == 3)
                {
                    Debug.Log("Rock!");
                    Debug.Log("Console wins!");
                }

                break;
            case 2:
                if (userNumber == 2)
                {
                    Debug.Log("Paper");
                    Debug.Log("Its a tie.");
                }
                else if (userNumber == 1)
                {
                    Debug.Log("Paper");
                    Debug.Log("Console wins!");
                }
                else if (userNumber == 3)
                {
                    Debug.Log("Paper");
                    Debug.Log("User wins!");
                }
                break;
            case 3:
                if (userNumber == 3)
                {
                    Debug.Log("Scissors");
                    Debug.Log("Its a tie.");
                }
                else if (userNumber == 2)
                {
                    Debug.Log("Scissors");
                    Debug.Log("Console wins!");
                }
                else if (userNumber == 3)
                {

                    Debug.Log("User wins!");
                }
                break;

        }
    }
}
