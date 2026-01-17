using UnityEngine;

public class FollowerFollowing : MonoBehaviour
{
    [SerializeField] private Rigidbody2D follower;
    [SerializeField] private Rigidbody2D target;
    [SerializeField] private float offset = 2f;

    void Update()
    {
        follower.position = new Vector3(target.position.x + offset, target.position.y + offset, 0);
    }
}
