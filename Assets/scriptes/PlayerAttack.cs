using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Shoting shooter;

    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Space)) return;
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

           
        Vector2 shootDirection = (mousePosition - shooter.firePoint.position).normalized;

        shooter.Shoot(shootDirection);
    }
}
