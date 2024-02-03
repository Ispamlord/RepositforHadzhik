using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealerLikeTrigger : MonoBehaviour
{
    public GameObject obj; 
    public int damageAmount = 10; 
    public bool shouldDamagePlayer = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        
        if (damageReceiver != null && !collision.isTrigger)
        {
            
            if ((collision.name != "Player") || shouldDamagePlayer)
            {
                damageReceiver.TakeDamage(damageAmount);
            }

        }
    }
}
