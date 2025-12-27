using UnityEngine;

public class PMovement : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) transform.position += new Vector3(0, 1, 0) * speed;
        if (Input.GetKeyDown(KeyCode.S)) transform.position += new Vector3(0, -1, 0) * speed;
        if (Input.GetKeyDown(KeyCode.A)) transform.position += new Vector3(-1, 0, 0) * speed;
        if (Input.GetKeyDown(KeyCode.D)) transform.position += new Vector3(1, 0, 0) * speed;
    }
}
