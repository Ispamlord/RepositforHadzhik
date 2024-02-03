using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float speed = 5f;
    private CircleCollider2D circleCollider;
    Collider2D coll;
    private bool isMoving = false;
    
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        circleCollider = this.GetComponent<CircleCollider2D>();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            isMoving = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            move();
            isMoving = true;
        }

    }
    private void move()
    {
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
    }
    
    private void FixedUpdate()
    {
        if(isMoving) {
            MoveChar(movement);
        }
        
    }
    private void MoveChar(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
        
    }
}
