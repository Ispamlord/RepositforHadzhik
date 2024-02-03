using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealerLikeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public int damageAmount = 10; // �������� �����, ������� ������ ����� �������
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageReceiver damageReceiver = collision.GetComponent<DamageReceiver>();
        // ���� ������ ����� �������������� "damage", �������� ����� �������� �����
        if (damageReceiver != null && !collision.isTrigger)
        {
            damageReceiver.TakeDamage(damageAmount);
        }
    }
}
