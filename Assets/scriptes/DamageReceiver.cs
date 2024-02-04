using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    public int health = 100; // Здоровье объекта

    // Метод для принятия урона
    public void TakeDamage(int damage)
    {
        health -= damage;

        // Дополнительная логика при получении урона, например, проверка на смерть
        if (health <= 0)
        {
            Die();
        }
    }

    // Метод для обработки смерти объекта
    private void Die()
    {
        // Логика при смерти объекта
        Destroy(gameObject);
    }
}
