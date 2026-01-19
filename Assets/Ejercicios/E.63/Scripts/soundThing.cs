using UnityEngine;

public class soundThing : MonoBehaviour
{
    [SerializeField] private AudioSource coinSound; // https://www.youtube.com/watch?v=mvaUho_a-q4

    void OnTriggerEnter2D(Collider2D collision)
    {
        coinSound.Play();
    }
}
