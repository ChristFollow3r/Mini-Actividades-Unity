using UnityEngine;

public class ObjectFollower : MonoBehaviour
{
    [SerializeField] private Rigidbody2D square;
    [SerializeField] private Rigidbody2D stalker;
    [SerializeField] private float speed = 3f;

    void Start()
    {

    }

    void Update()
    {
        stalker.transform.position = Vector3.Lerp(stalker.transform.position, square.transform.position, Time.deltaTime * speed);
    }
}
