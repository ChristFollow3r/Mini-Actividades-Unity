using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 7f;
    [SerializeField] private Collider2D OverlapCircle;
    private BoxCollider2D dude;
    [SerializeField] private float explosionForce = 10f;
    [SerializeField] private float radius = 3f;


    InputSystem_Actions inputActions;
    float space;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dude = GetComponent<BoxCollider2D>(); // Que no quiero que mi cubo explote tambien
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }

    void Update()
    {
        Movement();
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        if (space != 0)
        {
            for (int i = colliders.Length - 1; i > 0; i--)
            {
                if (colliders[i].attachedRigidbody == OverlapCircle || colliders[i].attachedRigidbody == dude) continue;
                if (colliders[i].attachedRigidbody) colliders[i].attachedRigidbody.AddForce((colliders[i].transform.position) * explosionForce);
            }
        }

        void Movement()
        {
            Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>();
            rb.position += new Vector2(movement.x, movement.y) * speed * Time.deltaTime;
            space = inputActions.Player.Jump.ReadValue<float>();
        }

    }
}