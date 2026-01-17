using UnityEngine;

public class PointsOnCollisions : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float speed = 7f;
    private InputSystem_Actions moveActions;
    private int points = 0;

    void Start()
    {
        moveActions = new InputSystem_Actions();
        moveActions.Player.Enable();
    }

    void Update()
    {
        Movement();

    }

    void Movement()
    {
        Vector2 movement = moveActions.Player.Move.ReadValue<Vector2>();
        playerRb.linearVelocityX = movement.x * speed;
        playerRb.linearVelocityY = movement.y * speed;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(points += 10);
    }
}
