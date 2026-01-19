using UnityEngine;

public class brwqeurouwqerfyeo : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 7f;
    InputSystem_Actions inputActions;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }

    void Update()
    {
        Movement();

    }

    void Movement()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>();
        rb.position += new Vector2(movement.x, movement.y) * speed * Time.deltaTime;
    }
}
