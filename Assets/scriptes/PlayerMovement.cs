using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 moveVector;
    private SpriteRenderer sp;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    //public void Update()
    //{
    //    Move();
    //}

    public void Move()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        sp.flipX = moveVector.x < 0f;
        rb.MovePosition(rb.position + moveVector * (speed * Time.deltaTime));
    }
}
