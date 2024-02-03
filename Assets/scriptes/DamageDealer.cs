using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10; // Значение урона, которое объект может нанести

    // Вызывается при столкновении с другим коллайдером
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверяем, столкнулись ли с объектом, который имеет характеристику "damage"
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();

        // Если объект имеет характеристику "damage", вызываем метод передачи урона
        if (damageReceiver != null)
        {
            damageReceiver.TakeDamage(damageAmount);
        }
    }

}
