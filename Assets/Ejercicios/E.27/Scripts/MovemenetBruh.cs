using UnityEngine;

public class MovemenetBruh : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private Rigidbody2D player;

    // private InputSystem_Actions inputSystem_actions;
    // private void Awake()
    // {
    //     inputSystem_actions = new InputSystem_Actions();
    //     inputSystem_actions.Player.Enable();
    // }

    void Update()
    {
        float upDown = 0f;
        float leftRight = 0f;


        if (Input.GetKey(KeyCode.W)) upDown = 1f;
        if (Input.GetKey(KeyCode.S)) upDown = -1f;
        if (Input.GetKey(KeyCode.A)) leftRight = -1f;
        if (Input.GetKey(KeyCode.D)) leftRight = 1f;

        Vector2 input = new Vector2(leftRight, upDown);
        Vector3 movement = new Vector3(input.x * speed * Time.deltaTime, input.y * speed * Time.deltaTime, 0f);
        player.transform.position += movement;


    }



}
