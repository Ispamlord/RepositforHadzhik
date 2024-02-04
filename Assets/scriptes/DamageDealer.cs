using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10; 

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();
        if (damageReceiver != null)
        {
            damageReceiver.TakeDamage(damageAmount);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();
        if (damageReceiver != null)
        {
            damageReceiver.TakeDamage(damageAmount/5);
        }
    }
}
