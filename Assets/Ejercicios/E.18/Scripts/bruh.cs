using UnityEngine;

public class bruh : MonoBehaviour
{
    [SerializeField] private float speed = 3f;
    [SerializeField] private Rigidbody2D square;

    void Start()
    {

    }

    void Update()
    {
        square.transform.Translate(new Vector2(-1, 1) * speed * Time.deltaTime); // XD
    }
}
