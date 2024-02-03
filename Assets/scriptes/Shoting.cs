using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shoting : MonoBehaviour
{
    
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
