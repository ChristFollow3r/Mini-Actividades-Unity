using UnityEngine;

public class ChangeColorOnTrigger : MonoBehaviour
{

    [SerializeField] private float speed = 7f;
    [SerializeField] private Rigidbody2D square;
    [SerializeField] private SpriteRenderer squareRenderer;

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
        // square.GetComponent<SpriteRenderer>().material.color = new Color(220, 20, 60);
        squareRenderer.color = new Color(1f, 0f, 0f);
        // Of course the rgb is not a fucking rgb wtf. How the fuck is 1?
        // Debug.Log("Has entered the trigger");
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        squareRenderer.color = new Color(1f, 1f, 1f);
        // if (squareRenderer.material.color == null) Debug.Log("This doesnt have a material");
        // square.GetComponent<SpriteRenderer>().material.color = SpriteRenderer
        // Debug.Log("Has exited the trigger");
    }

    Vector2 GetMovement()
    {
        Vector2 movement = inputSystem_actions.Player.Move.ReadValue<Vector2>();
        return movement;
    }
}
