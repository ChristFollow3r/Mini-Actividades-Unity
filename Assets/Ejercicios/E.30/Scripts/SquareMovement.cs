using UnityEngine;

public class SquareMovement : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private Rigidbody2D square;

    private InputSystem_Actions inputSystem_actions;

    private void Awake()
    {
        inputSystem_actions = new InputSystem_Actions();
        inputSystem_actions.Player.Enable();
    }

    void FixedUpdate()
    {
        Vector2 movement = square.position + GetMovement() * speed * Time.fixedDeltaTime;
        square.MovePosition(movement);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Has entered the trigger");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Has exited the trigger");
    }

    Vector2 GetMovement()
    {
        Vector2 movement = inputSystem_actions.Player.Move.ReadValue<Vector2>();
        return movement;
    }
}
