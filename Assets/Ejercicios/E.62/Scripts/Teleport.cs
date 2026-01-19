using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform LeftPortal;

    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = LeftPortal.transform.position;
    }
}
