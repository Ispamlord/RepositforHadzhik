using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponeController : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector2 lookDirection;
    private void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        lookDirection = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}