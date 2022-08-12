using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoSpeedScript : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public float moveSpeed = 15f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody2D.AddForce(new Vector2 (moveSpeed , 0f));
        }
    }
}
