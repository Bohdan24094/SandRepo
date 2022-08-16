using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GusButtonScript : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed = 1000f;



    public void Update()
    {
       // if (Input.GetButtonDown("GusButton"))
       // {
            rb.AddForce(new Vector2(speed, 0f));

       // }
    }
}
