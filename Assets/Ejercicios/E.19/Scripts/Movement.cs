using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
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

// I didnt use the position method but I think this is way better.