using UnityEngine;

public class FollowerFollowing5mDude : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float speed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        GetClose();
    }

    void GetClose()
    {
        float distance = Vector2.Distance(rb.position, player.position);
        if (distance <= 5f)
        {
            rb.position = Vector2.MoveTowards(rb.position, player.position, speed * Time.deltaTime);
        }
    }
}
