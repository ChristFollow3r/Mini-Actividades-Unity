using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 9f; // Mega massive yoink from the last exercise
    [SerializeField] private Rigidbody2D square;
    private InputSystem_Actions inputSystem_actions;
    private void Awake()
    {
        inputSystem_actions = new InputSystem_Actions();
        inputSystem_actions.Player.Enable();
    }

    void Update()
    {
        square.transform.Translate(GetMovement() * speed * Time.deltaTime);
        Debug.Log(GetMovement());
    }

    Vector2 GetMovement()
    {
        Vector2 movement = inputSystem_actions.Player.Move.ReadValue<Vector2>();
        return movement;
    }
}
