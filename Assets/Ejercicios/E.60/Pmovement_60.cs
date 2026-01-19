using UnityEngine;
using TMPro;

public class Pmovement_60 : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed = 7f;
    [SerializeField] private GameObject ball;
    [SerializeField] private TMP_Text timer;
    [SerializeField] private TMP_Text counter;
    int bruh;
    int counterXD = 0;
    int counterBruh = 0;

    InputSystem_Actions inputActions;

    private float targetTime = 5f; // https://discussions.unity.com/t/simple-timer/56201
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
        targetTime -= Time.deltaTime;
        bruh = (int)targetTime; // https://discussions.unity.com/t/converting-float-to-integer/395668
        counter.text = "Counter: " + counterBruh.ToString();
        timer.text = "Cooldown: " + bruh.ToString();

        if (counterXD <= 4 && targetTime <= 0) timer.text = "Time to take a dump!";
        if (counterXD >= 5 && targetTime <= 0) timer.text = "Poop rush time!";
        if (targetTime <= 0.0f) TimerEnded();
        Debug.Log(targetTime);
    }

    void Movement()
    {
        Vector2 movement = inputActions.Player.Move.ReadValue<Vector2>();
        rb.position += new Vector2(movement.x, movement.y) * speed * Time.deltaTime;
    }

    void TimerEnded()
    {
        space = inputActions.Player.Jump.ReadValue<float>();

        if (space != 0)
        {
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = rb.transform.position;
            targetTime = 5f;
            counterXD++;
            counterBruh++;
            if (counterXD >= 5) targetTime = 2f;
        }

    }
}
