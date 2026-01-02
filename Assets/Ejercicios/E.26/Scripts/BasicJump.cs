using UnityEngine;

public class BasicJump : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float jumpForce = 7f;
    private InputSystem_Actions inputSystem_actions;

    void Awake()
    {
        inputSystem_actions = new InputSystem_Actions();
        inputSystem_actions.Player.Enable();
    }

    void Update()
    {
        if (Jump() == true) player.linearVelocityY = jumpForce;
    }

    bool Jump()
    {
        float jump = inputSystem_actions.Player.Jump.ReadValue<float>();

        if (jump > 0) return true;
        else return false;
    }
}
