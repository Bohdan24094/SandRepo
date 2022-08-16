using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotoSpeedScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float forwardForce = 100f;
    
public void FixedUpdate()
    {
        if (Input.GetButton("GasButton"))
        {
            rb.AddForce(new Vector2(forwardForce, 0f));
        }
        
    }
}
