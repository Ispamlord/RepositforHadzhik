using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shoting : MonoBehaviour
{
    //public Transform firePoint;  // Позиция, откуда будет выпущена стрела
    //public GameObject arrowPrefab;  // Префаб стрелы
    //public float arrowForce = 20f;  // Сила стрельбы

    //// Функция для стрельбы
    //void Shoot()
    //{
    //    // Получаем позицию мыши в мировых координатах
    //    Vector3 mousePosition = Input.mousePosition;
    //    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

    //    // Создаем экземпляр стрелы из префаба
    //    GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

    //    // Получаем компонент Rigidbody2D стрелы
    //    Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

    //    // Вычисляем направление от firePoint к позиции мыши
    //    Vector2 shootDirection = (mousePosition - firePoint.position).normalized;

    //    // Придаем стреле силу в указанном направлении
    //    rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
    //}
    public Transform firePoint;
    public GameObject arrowPrefab;
    public float arrowForce = 20f;

    public void Shoot(Vector2 shootDirection)
    {
        // Создаем экземпляр стрелы из префаба
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

        // Получаем компонент Rigidbody2D стрелы
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();

        // Придаем стреле силу в указанном направлении
        rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
    }

}
