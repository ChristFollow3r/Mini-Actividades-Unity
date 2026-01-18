using UnityEngine;

public class pMDestruction : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 7f;
    [SerializeField] private Collider2D OverlapCircle;
    InputSystem_Actions inputActions;
    float space;

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
        space = inputActions.Player.Jump.ReadValue<float>();
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (space != 0) Destroy(collision.gameObject);
    }


}
