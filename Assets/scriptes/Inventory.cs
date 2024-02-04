using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int Healka = 0;
    public int Heal = 20;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && Healka > 0)
        {
            DamageReceiver damageReceiver = GetComponent<DamageReceiver>();
            damageReceiver.TakeDamage(-Heal);
            Healka--;
        }
    }
}
