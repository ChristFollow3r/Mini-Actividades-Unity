using UnityEngine;

public class BruhStalker : MonoBehaviour
{
    [SerializeField] private Rigidbody2D square;
    [SerializeField] private Rigidbody2D stalker;

    void Start()
    {

    }


    void Update()
    {
        Vector3 stalkerPosition = square.transform.position - new Vector3(-1.5f, 0, 0);
        stalker.transform.position = stalkerPosition;
    }
}
