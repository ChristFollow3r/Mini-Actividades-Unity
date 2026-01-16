using UnityEngine;

public class MovementPlusCamera : MonoBehaviour
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
        square.transform.Translate(GetMovement() * speed * Time.deltaTime);
    }

    Vector2 GetMovement()
    {
        Vector2 movement = inputSystem_actions.Player.Move.ReadValue<Vector2>();
        return movement;
    }

}
