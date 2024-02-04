using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealerLikeTrigger : MonoBehaviour
{
    public int damageAmount = 10; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        if (damageReceiver != null && !collision.isTrigger)
        {
            Character character = this.gameObject.GetComponent<Character>();
            if (character.owner != collision.gameObject)
            {
                damageReceiver.TakeDamage(damageAmount);
            }

        }
    }
}
