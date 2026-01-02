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

        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.W)) y = 1f;
        if (Input.GetKey(KeyCode.S)) y = -1f;
        if (Input.GetKey(KeyCode.A)) x = -1f;
        if (Input.GetKey(KeyCode.D)) x = 1f;

        Vector2 input = new Vector2(x, y);
        Vector3 movement = new Vector3(input.x * speed * Time.deltaTime, input.y * speed * Time.deltaTime, 0f);
        player.transform.position += movement;


    }



}
