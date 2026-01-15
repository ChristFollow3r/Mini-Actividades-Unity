using UnityEngine;

public class tagTriggerScript : MonoBehaviour
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
        // Debug.Log("Trigger working");
        if (collision.CompareTag("square1")) Debug.Log("Dude entered square 1");
        else Debug.Log("Dude entered square 2");

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // if (square.CompareTag("Square1")) Debug.Log("Dude entered square 1");
        // else Debug.Log("Dude entered square two");
    }

    Vector2 GetMovement()
    {
        Vector2 movement = inputSystem_actions.Player.Move.ReadValue<Vector2>();
        return movement;
    }
}
