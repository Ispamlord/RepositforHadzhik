using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform target;
    private Rigidbody2D rb;
    private Vector2 movement;
    private float speed = 5f;
    private bool isMoving = false;
    
    public void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }
    
    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if (collision.name == target.name)
        {
            isMoving = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.name == target.name)
        {
            move();
            isMoving = true;
        }
    }
    private void move()
    {
        Vector2 direction = target.position - transform.position;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
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
