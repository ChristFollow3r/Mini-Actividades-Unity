using UnityEngine;

public class RPS : MonoBehaviour
{
    public enum userNumber { Rock = 1, Paper, Scissors };
    public userNumber choseYourPokemon;

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
                if (choseYourPokemon == userNumber.Rock)
                {
                    Debug.Log("Rock!");
                    Debug.Log("Its a tie.");
                }
                else if (choseYourPokemon == userNumber.Paper)
                {
                    Debug.Log("Rock!");
                    Debug.Log("User wins!");
                }
                else if (choseYourPokemon == userNumber.Scissors)
                {
                    Debug.Log("Rock!");
                    Debug.Log("Console wins!");
                }

                break;
            case 2:
                if (choseYourPokemon == userNumber.Paper)
                {
                    Debug.Log("Paper");
                    Debug.Log("Its a tie.");
                }
                else if (choseYourPokemon == userNumber.Rock)
                {
                    Debug.Log("Paper");
                    Debug.Log("Console wins!");
                }
                else if (choseYourPokemon == userNumber.Scissors)
                {
                    Debug.Log("Paper");
                    Debug.Log("User wins!");
                }
                break;
            case 3:
                if (choseYourPokemon == userNumber.Scissors)
                {
                    Debug.Log("Scissors");
                    Debug.Log("Its a tie.");
                }
                else if (choseYourPokemon == userNumber.Paper)
                {
                    Debug.Log("Scissors");
                    Debug.Log("Console wins!");
                }
                else if (choseYourPokemon == userNumber.Rock)
                {
                    Debug.Log("Scissors");
                    Debug.Log("User wins!");
                }
                break;

        }
    }
}
