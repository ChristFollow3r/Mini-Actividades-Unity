
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    [SerializeField] Rigidbody2D square;

    void Start()
    {
        square.position = new Vector2(Random.Range(-9f, 9f), square.position.y);
    }


}
