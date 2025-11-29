using UnityEngine;

public class RandomNumbers : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float randomNumbers = Random.Range(-9, 10); // Dices en el enunciado entre -10 diez y 10 (por eso pongo -9 i 10).
        Debug.Log(randomNumbers);
    }
}
