using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private float followSpeed = 2f;
    [SerializeField] private Transform target;
    
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - target.position;
    }

    private void Update()
    {
        Vector3 newPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, newPos, followSpeed * Time.deltaTime);
    }
}

