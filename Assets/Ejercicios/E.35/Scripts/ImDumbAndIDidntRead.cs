using Unity.VisualScripting;
using UnityEngine;

public class ImDumbAndIDidntRead : MonoBehaviour
{
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private float cameraSpeed = 5f;



    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, player.transform.position, cameraSpeed);
    }
}
