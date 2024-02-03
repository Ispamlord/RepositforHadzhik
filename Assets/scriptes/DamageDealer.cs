using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damageAmount = 10; // �������� �����, ������� ������ ����� �������

    // ���������� ��� ������������ � ������ �����������
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // ���������, ����������� �� � ��������, ������� ����� �������������� "damage"
        DamageReceiver damageReceiver = collision.gameObject.GetComponent<DamageReceiver>();

        // ���� ������ ����� �������������� "damage", �������� ����� �������� �����
        if (damageReceiver != null)
        {
            damageReceiver.TakeDamage(damageAmount);
        }
    }

}
