using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Shoting shooter;
    private void Start()
    {
        shooter = GetComponent<Shoting>();
    }
    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 shootDirection = (mousePosition - shooter.firePoint.position).normalized;
        shooter.Shoot(shootDirection);
    }
}
