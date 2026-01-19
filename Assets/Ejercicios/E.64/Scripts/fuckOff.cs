using System.Threading;
using UnityEngine;

public class fuckOff : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 7f;
    [SerializeField] private GameObject shit;
    [SerializeField] private AudioSource coinSound;
    [SerializeField] private float timer = 1f;
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
        timer -= Time.deltaTime;

    }

    void Movement()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>();
        float space = inputActions.Player.Jump.ReadValue<float>();
        rb.position += new Vector2(movement.x, movement.y) * speed * Time.deltaTime;
        if (space != 0 && timer <= 0)
        {
            GameObject newShit = Instantiate(shit);
            newShit.transform.position = rb.transform.position;
            Destroy(newShit, 5f);
            coinSound.Play();
            timer = 1f;
        }
    }
}
