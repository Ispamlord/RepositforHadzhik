using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Shoting shooter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Получаем позицию мыши в мировых координатах
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Вычисляем направление от firePoint к позиции мыши
            Vector2 shootDirection = (mousePosition - shooter.firePoint.position).normalized;

            // Вызываем стрельбу у компонента Shooter
            shooter.Shoot(shootDirection);
        }
    }
}
