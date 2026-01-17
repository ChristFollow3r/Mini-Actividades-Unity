using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float speed = 7f;
    [SerializeField] private TMP_Text coinCounter;
    private int counter = 0;
    InputSystem_Actions moveActions;

    void Start()
    {
        moveActions = new InputSystem_Actions();
        moveActions.Player.Enable();
    }

    void Update()
    {
        Movement();

    }

    void Movement()
    {
        Vector2 movement = moveActions.Player.Move.ReadValue<Vector2>();
        playerRb.linearVelocityX = movement.x * speed;
        playerRb.linearVelocityY = movement.y * speed;

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        counter++;
        coinCounter.text = counter.ToString();
    }
}
