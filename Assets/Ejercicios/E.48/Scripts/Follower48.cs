using Unity.VisualScripting;
using UnityEngine;

public class Follower48 : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Rigidbody2D player;
    private float fixedY = -3.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.position = new Vector2(player.position.x, fixedY);

    }
}
