using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSpeedButtton : MonoBehaviour
{
    public Rigidbody2D rb;
    public float backForce = -100f;


    private void FixedUpdate()
    {
        if (Input.GetButton("StopButton"))
        {
            rb.AddForce(new Vector2(backForce, 0f));
        }
    }
   
}
