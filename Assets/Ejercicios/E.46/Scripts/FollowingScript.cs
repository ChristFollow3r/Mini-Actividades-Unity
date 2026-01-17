using Unity.VisualScripting;
using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D target;
    [SerializeField] private float speed = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.position = Vector3.MoveTowards(rb.position, target.position, speed * Time.deltaTime);
    }
}
