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
        _moveVector.x = Input.GetAxisRaw("Horizontal");
        _moveVector.y = Input.GetAxisRaw("Vertical");
        _spriteRenderer.flipX = _moveVector.x < 0f;
        _displacement = _moveVector.normalized * Time.deltaTime;
        _displacement.x = _displacement.x > 0.002 || _displacement.x < -0.002 ? 0.002f * _moveVector.x : _displacement.x;
        _displacement.y = _displacement.y > 0.002 || _displacement.y < -0.002 ? 0.002f * _moveVector.y : _displacement.y;
        _rigidbody2D.MovePosition(_rigidbody2D.position + _displacement * speed);
    }
}
