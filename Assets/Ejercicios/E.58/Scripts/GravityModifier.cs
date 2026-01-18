using Unity.VisualScripting;
using UnityEngine;

public class GravityModifier : MonoBehaviour
{
    [SerializeField] private Rigidbody2D box1;
    [SerializeField] private Rigidbody2D box2;
    [SerializeField] private Rigidbody2D box3;
    [SerializeField] private Rigidbody2D box4;
    [SerializeField] private Rigidbody2D box5;
    InputSystem_Actions inputActions;
    float spaceBar;
    Vector2 reverseGravity;


    void Start()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }

    void Update()
    {
        FlipGravity();
    }

    void FlipGravity()
    {
        spaceBar = inputActions.Player.Jump.ReadValue<float>();
        reverseGravity = inputActions.Player.Move.ReadValue<Vector2>();
        if (spaceBar != 0)
        {
            box1.gravityScale = -1;
            box2.gravityScale = -1;
            box3.gravityScale = -1;
            box4.gravityScale = -1;
            box5.gravityScale = -1;
        }

        if (reverseGravity.x != 0 || reverseGravity.y != 0)
        {
            box1.gravityScale = 1;
            box2.gravityScale = 1;
            box3.gravityScale = 1;
            box4.gravityScale = 1;
            box5.gravityScale = 1;
        }
    }
}
