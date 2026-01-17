using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementDestroy : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float speed = 7f;
    InputSystem_Actions moveActions;

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
        Destroy(collision.gameObject);
        Debug.Log("Entered collider");
    }
}
