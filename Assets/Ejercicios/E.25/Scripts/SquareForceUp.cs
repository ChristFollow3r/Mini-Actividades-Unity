using UnityEngine;

public class SquareForceUp : MonoBehaviour
{
    [SerializeField] private Rigidbody2D square;
    [SerializeField] private float yeet = 7f;


    void Start()
    {
        square.AddForce(square.transform.up * yeet, ForceMode2D.Impulse);
    }
}
