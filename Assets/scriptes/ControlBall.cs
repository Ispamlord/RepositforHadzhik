using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 moveVector;
    public float speed = 20;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    public void Use()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
    // public void FixedUpdate()
    // {
    //     
    // }
}
