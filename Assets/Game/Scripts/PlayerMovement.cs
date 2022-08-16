using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] private float forwardForce = 100f;
    [SerializeField] float backForce = -100f;


    public void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(forwardForce, 0f));
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(backForce, 0f));
        }

    }
}
