using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite;
    InputSystem_Actions inputActions;
    void Start()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }


    void Update()
    {
        PressSpaceBar();
    }

    void PressSpaceBar()
    {
        float space = inputActions.Player.Jump.ReadValue<float>();

        if (space == 0)
        {
            sprite.flipX = false;
        }
        else sprite.flipX = true;
    }
}
