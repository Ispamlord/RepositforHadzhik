using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed = 40f;
    private Vector2 _moveVector;
    // private BoxCollider2D boxCollider;
    private Rigidbody2D _rigidbody2D;
    private SpriteRenderer _spriteRenderer;

    private Vector2 _displacement;
    public void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        // boxCollider = GetComponent<BoxCollider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Update()
    {
        Move();
    }

    private void Move()
    {
        _moveVector.x = Input.GetAxisRaw("Horizontal");
        _moveVector.y = Input.GetAxisRaw("Vertical");
        _spriteRenderer.flipX = _moveVector.x < 0f;

        _displacement = _moveVector.normalized * Time.deltaTime;

        _displacement.x = _displacement.x > 0.002||_displacement.x < -0.002 ? 0.002f*_moveVector.x : _displacement.x;
        _displacement.y = _displacement.y > 0.002||_displacement.y < -0.002 ? 0.002f*_moveVector.y : _displacement.y;
        _rigidbody2D.MovePosition(_rigidbody2D.position + _displacement*speed);

    }
}