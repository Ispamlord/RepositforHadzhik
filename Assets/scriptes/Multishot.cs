using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multishot : MonoBehaviour
{
    public float arrowForce = 10f;
    public Transform firePoint;
    public GameObject arrowPrefab;
    public float cooldownTime = 1f; // Время перезарядки в секундах
    private bool isCooldown = false;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)&& !isCooldown)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        isCooldown = true;
        Invoke("ResetCooldown", cooldownTime);

        // Создаем 8 стрел во всех направлениях
        for (float angle = 0; angle < 360; angle += 45)
        {
            // Создаем экземпляр стрелы из префаба
            GameObject arrow = Instantiate(arrowPrefab, firePoint.position, Quaternion.Euler(0, 0, angle));

            // Получаем компонент Rigidbody2D стрелы
            Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

            // Вычисляем направление для каждой стрелы
            Vector2 shootDirection = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));

            // Придаем стреле силу в указанном направлении
            rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
        }
    }

    void ResetCooldown()
    {
        // Сбрасываем перезарядку
        isCooldown = false;
    }
}
