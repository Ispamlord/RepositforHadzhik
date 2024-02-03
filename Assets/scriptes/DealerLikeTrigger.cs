using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealerLikeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageAmount = 10; // Çíà÷åíèå óðîíà, êîòîðîå îáúåêò ìîæåò íàíåñòè
    public bool shouldDamagePlayer = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        // Åñëè îáúåêò èìååò õàðàêòåðèñòèêó "damage", âûçûâàåì ìåòîä ïåðåäà÷è óðîíà
        if (damageReceiver != null && !collision.isTrigger)
        {
            // (collision.name == "Player"&&!shouldDamagePlayer)
            if (!((collision.name != "Player") || shouldDamagePlayer))
            {
                damageReceiver.TakeDamage(damageAmount);
            }

        }
    }
}
