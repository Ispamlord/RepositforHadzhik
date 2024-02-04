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
    private GameObject owner;
    public void Shoot(Vector2 shootDirection)
    {
        // Создаем экземпляр стрелы из префаба
        GameObject arrow = Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);

        Character character = arrow.GetComponent<Character>();
        character.owner = this.gameObject;
        // Получаем компонент Rigidbody2D стрелы
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        
        
        // Придаем стреле силу в указанном направлении
        rb.AddForce(shootDirection * arrowForce, ForceMode2D.Impulse);
    }

}
