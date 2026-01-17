using System;
using UnityEngine;

public class FollowCameraWithOffset : MonoBehaviour
{
    private float length;
    private float startPosition;
    [SerializeField] private float parallaxEfect;
    [SerializeField] private GameObject camera;

    void Start()
    {
        startPosition = transform.position.x;
        // length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        float temp = (camera.transform.position.x * (1 - parallaxEfect));
        float dist = (camera.transform.position.x * parallaxEfect);

        transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);

        if (temp > startPosition + length) startPosition += length;
        else if (temp < startPosition - length) startPosition -= length;
    }

}
