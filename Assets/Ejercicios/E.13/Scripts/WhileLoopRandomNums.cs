using UnityEngine;

public class WhileLoopRandomNums : MonoBehaviour
{


    void Start()
    {
        int conuter = 0;

        while (conuter != 100)
        {
            int numbers = Random.Range(1, 101);
            Debug.Log(conuter + 1 + ": " + numbers);
            conuter++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
