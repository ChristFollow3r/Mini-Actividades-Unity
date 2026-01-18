using UnityEngine;

public class dinoScriptAnim : MonoBehaviour
{
    [SerializeField] private Animator dinoAnimator;
    InputSystem_Actions inputActions;
    void Start()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float movement = inputActions.Player.Jump.ReadValue<float>();

        if (movement != 0)
        {
            dinoAnimator.SetBool("isRunning", true);
        }

        else dinoAnimator.SetBool("isRunning", false);
    }

}
