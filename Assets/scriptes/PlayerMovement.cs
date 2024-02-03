using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 moveVector;
    private BoxCollider2D boxCollider;
    private SpriteRenderer sp;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        move();
    }
    public void move()
    {
        moveVector.x = Input.GetAxisRaw("Horizontal");
        moveVector.y = Input.GetAxisRaw("Vertical");
        if(moveVector.x > 0f)
        {
            sp.flipX = false;
        }
        if (moveVector.x < 0f)
        {
            sp.flipX = true;
        }
        
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}
