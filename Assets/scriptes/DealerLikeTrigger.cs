using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealerLikeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageAmount = 10; // Значение урона, которое объект может нанести
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        // Если объект имеет характеристику "damage", вызываем метод передачи урона
        if (damageReceiver != null && !collision.isTrigger)
        {
            damageReceiver.TakeDamage(damageAmount);
        }
    }
}
